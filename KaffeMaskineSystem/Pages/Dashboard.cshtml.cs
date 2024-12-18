using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace KaffeMaskineSystem.Pages
{
    public class DashboardModel : PageModel
    {
        public string UserEmail { get; set; }

        public void OnGet()
        {
            UserEmail = HttpContext.Session.GetString("UserEmail");

            // Hvis brugeren ikke er logget ind, redirect til login
            if (string.IsNullOrEmpty(UserEmail))
            {
                Response.Redirect("/Login");
            }
        }
    }
}
