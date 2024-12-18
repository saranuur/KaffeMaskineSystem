using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class MachineMaintenanceRecordPageModel : PageModel
{
    private readonly MachineMaintenanceRecordService _maintenanceRecordService;

    [BindProperty]
    public MachineMaintenanceRecord NewRecord { get; set; }

    public IEnumerable<MachineMaintenanceRecord> MaintenanceRecords { get; set; }

    public MachineMaintenanceRecordPageModel(MachineMaintenanceRecordService maintenanceRecordService)
    {
        _maintenanceRecordService = maintenanceRecordService;
    }

    public async Task OnGetAsync()
    {
        MaintenanceRecords = await _maintenanceRecordService.GetAllRecordsAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            await _maintenanceRecordService.AddRecordAsync(NewRecord);
            return RedirectToPage();
        }
        return Page();
    }

    public async Task<IActionResult> OnGetEditAsync(int id)
    {
        var record = await _maintenanceRecordService.GetRecordByIdAsync(id);
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
            NewRecord.MachineMaintenanceRecordID = id;
            await _maintenanceRecordService.UpdateRecordAsync(NewRecord);
            return RedirectToPage();
        }
        return Page();
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var record = await _maintenanceRecordService.GetRecordByIdAsync(id);
        if (record == null)
        {
            return NotFound();
        }

        await _maintenanceRecordService.DeleteRecordAsync(id);
        return RedirectToPage();
    }
}
