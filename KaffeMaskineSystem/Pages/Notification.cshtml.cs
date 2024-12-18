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

        
        public async Task OnGetAsync()
        {
            Notifications = await _notificationService.GetAllNotificationsAsync();
        }

        
        public IActionResult OnGetCreate()
        {
            Notification = new Notification(); 
            return Page(); 
        }

        
        public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }

            await _notificationService.AddNotificationAsync(Notification);
            return RedirectToPage("/NotificationPage"); 
        }

        
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

