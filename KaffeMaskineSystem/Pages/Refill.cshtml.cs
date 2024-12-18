using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KaffeMaskineSystem.Pages
{
    public class RefillModel : PageModel
    {
        private readonly RefillService _refillService;

        public List<Refill> Refills { get; set; }

        public RefillModel(RefillService refillService)
        {
            _refillService = refillService;
        }

        public async Task OnGetAsync()
        {
            Refills = await _refillService.GetAllRefillsAsync();
        }
    }
}
