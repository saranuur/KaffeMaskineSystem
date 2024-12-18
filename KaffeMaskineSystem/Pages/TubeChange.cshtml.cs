using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class TubeChangePageModel : PageModel
{
    private readonly TubeChangeService _tubeChangeService;

    [BindProperty]
    public TubeChange NewChange { get; set; }

    public IEnumerable<TubeChange> TubeChanges { get; set; }

    public TubeChangePageModel(TubeChangeService tubeChangeService)
    {
        _tubeChangeService = tubeChangeService;
    }

    public async Task OnGetAsync()
    {
        TubeChanges = await _tubeChangeService.GetAllChangesAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            await _tubeChangeService.AddChangeAsync(NewChange);
            return RedirectToPage();
        }
        return Page();
    }

    public async Task<IActionResult> OnGetEditAsync(int id)
    {
        var change = await _tubeChangeService.GetChangeByIdAsync(id);
        if (change == null)
        {
            return NotFound();
        }
        NewChange = change;
        return Page();
    }

    public async Task<IActionResult> OnPostEditAsync(int id)
    {
        if (ModelState.IsValid)
        {
            // Hent den eksisterende TubeChange
            var changeToUpdate = await _tubeChangeService.GetChangeByIdAsync(id);

            if (changeToUpdate == null)
            {
                return NotFound();  // Hvis ændringen ikke findes, returnér en 404
            }

            // Opdater de relevante felter med data fra NewChange (de nye data brugeren har indtastet)
            changeToUpdate.ChangeDate = NewChange.ChangeDate;
            changeToUpdate.ChangedBy = NewChange.ChangedBy;
            changeToUpdate.CoffeeMachineID = NewChange.CoffeeMachineID;

            // Opdater den eksisterende TubeChange i databasen
            await _tubeChangeService.UpdateChangeAsync(changeToUpdate);

            // Redirect til samme side for at opdatere listen af ændringer
            return RedirectToPage();
        }
        return Page(); // Hvis model validation fejler, vis den nuværende side igen
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var change = await _tubeChangeService.GetChangeByIdAsync(id);
        if (change == null)
        {
            return NotFound();
        }

        await _tubeChangeService.DeleteChangeAsync(id);
        return RedirectToPage();
    }
}
