using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class TrayEmptyingRecordPageModel : PageModel
{
    private readonly TrayEmptyingRecordService _trayEmptyingRecordService;

    [BindProperty]
    public TrayEmptyingRecord NewRecord { get; set; }

    public IEnumerable<TrayEmptyingRecord> TrayEmptyingRecords { get; set; }

    public TrayEmptyingRecordPageModel(TrayEmptyingRecordService trayEmptyingRecordService)
    {
        _trayEmptyingRecordService = trayEmptyingRecordService;
    }

    public async Task OnGetAsync()
    {
        TrayEmptyingRecords = await _trayEmptyingRecordService.GetAllRecordsAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            await _trayEmptyingRecordService.AddRecordAsync(NewRecord);
            return RedirectToPage();
        }
        return Page();
    }

    public async Task<IActionResult> OnGetEditAsync(int id)
    {
        var record = await _trayEmptyingRecordService.GetRecordByIdAsync(id);
        if (record == null)
        {
            return NotFound();
        }
        NewRecord = record;
        return Page();
    }

    public async Task<IActionResult> OnPostEditAsync(int id)
    {
        if (ModelState.IsValid)
        {
            NewRecord.TrayEmptyingRecordID = id;
            await _trayEmptyingRecordService.UpdateRecordAsync(NewRecord);
            return RedirectToPage();
        }
        return Page();
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var record = await _trayEmptyingRecordService.GetRecordByIdAsync(id);
        if (record == null)
        {
            return NotFound();
        }

        await _trayEmptyingRecordService.DeleteRecordAsync(id);
        return RedirectToPage();
    }
}
