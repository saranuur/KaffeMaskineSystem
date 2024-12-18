using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using KaffeMaskineSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KaffeMaskineSystem.Pages
{
    public class NotificationPageModel : PageModel
    {
        private readonly NotificationService _notificationService;

        public IEnumerable<Notification> Notifications { get; set; }

        [BindProperty]
        public Notification Notification { get; set; }

        public NotificationPageModel(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        // Hent alle notifikationer og vis dem på siden
        public async Task OnGetAsync()
        {
            Notifications = await _notificationService.GetAllNotificationsAsync();
        }

        // Opret en ny notifikation (GET)
        public IActionResult OnGetCreate()
        {
            Notification = new Notification(); // Opret en tom notifikation til formularen
            return Page(); // Vis formularen
        }

        // Håndter oprettelse af en ny notifikation (POST)
        public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Hvis formularen ikke er gyldig, vis formularen igen
            }

            await _notificationService.AddNotificationAsync(Notification);
            return RedirectToPage("/NotificationPage"); // Omdiriger til oversigten over notifikationer
        }

        // Rediger en eksisterende notifikation (GET)
        public async Task<IActionResult> OnGetEditAsync(int id)
        {
            Notification = await _notificationService.GetNotificationByIdAsync(id);

            if (Notification == null)
            {
                return NotFound(); 
            }

            return Page(); 
        }

        
        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }

            await _notificationService.UpdateNotificationAsync(Notification);
            return RedirectToPage("/NotificationPage"); 
        }

       
        public async Task<IActionResult> OnGetDeleteAsync(int id)
        {
            Notification = await _notificationService.GetNotificationByIdAsync(id);

            if (Notification == null)
            {
                return NotFound(); 
            }

            return Page(); 
        }

        // Håndter sletning af en notifikation (POST)
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (Notification != null)
            {
                await _notificationService.DeleteNotificationAsync(Notification.NotificationID);
            }

            return RedirectToPage("/NotificationPage"); // Omdiriger til oversigten efter sletning
        }
    }
}

