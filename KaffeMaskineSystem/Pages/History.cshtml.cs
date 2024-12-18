using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KaffeMaskineSystem.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly HistoryService _historyService;

        public IEnumerable<History> Histories { get; set; }

        public HistoryModel(HistoryService historyService)
        {
            _historyService = historyService;
        }

        public async Task OnGetAsync()
        {
            Histories = await _historyService.GetAllHistoriesAsync();
        }
    }
}
