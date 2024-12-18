using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Pages.Cleanings
{
    public class CleaningDetailsModel : PageModel
    {
        private readonly CleaningService _cleaningService;

        public Cleaning Cleaning { get; set; }

        public CleaningDetailsModel(CleaningService cleaningService)
        {
            _cleaningService = cleaningService;
        }

        public async Task OnGetAsync(int cleaningId)
        {
            Cleaning = await _cleaningService.GetCleaningByIdAsync(cleaningId);
        }
    }
}
