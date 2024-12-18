using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KaffeMaskineSystem.Services;

namespace KaffeMaskineSystem.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserService _userService;

        public LoginModel(UserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (await _userService.AuthenticateUserAsync(Email, Password))
            {
                HttpContext.Session.SetString("UserEmail", Email);
                return RedirectToPage("/Dashboard");
            }

            ErrorMessage = "Invalid email or password.";
            return Page();
        }
    }
}
