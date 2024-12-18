using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KaffeMaskineSystem.Pages
{
    public class CoffeeMachineModel : PageModel
    {
        private readonly CoffeeMachineService _coffeeMachineService;

        public List<CoffeeMachine> CoffeeMachines { get; set; }

        public CoffeeMachineModel(CoffeeMachineService coffeeMachineService)
        {
            _coffeeMachineService = coffeeMachineService;
        }

        public async Task OnGetAsync()
        {
            CoffeeMachines = await _coffeeMachineService.GetAllCoffeeMachinesAsync();
        }
    }
}
