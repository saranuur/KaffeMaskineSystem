using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Pages.Cleanings
{
    public class CleaningModel : PageModel
    {
        private readonly CleaningService _cleaningService;

        [BindProperty]
        public Cleaning NewCleaning { get; set; }

        public List<Cleaning> Cleanings { get; set; }

        public CleaningModel(CleaningService cleaningService)
        {
            _cleaningService = cleaningService;
        }

        // Metode for at hente alle rengøringer.
        public async Task OnGetAsync()
        {
            Cleanings = await _cleaningService.GetAllCleaningsAsync();
        }

        // Metode for at oprette en ny rengøring.
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _cleaningService.AddCleaningAsync(NewCleaning.CoffeeMachineID, NewCleaning.CleanedBy, NewCleaning.CleaningDate);
                

                // Her tilgøjer vi  rengøringen til databasen
                var createdCleaning = await _cleaningService.AddCleaningAsync(NewCleaning.CoffeeMachineID, NewCleaning.CleanedBy, NewCleaning.CleaningDate);


                return RedirectToPage("/Cleanings/CleaningDetails", new { cleaningId = createdCleaning.CleaningID });
            }

            // Hvis der sker en  fejl i formularen, vil denne hjælpe os med at vise det igen
            Cleanings = await _cleaningService.GetAllCleaningsAsync();
            return Page();
        }
    }
}

