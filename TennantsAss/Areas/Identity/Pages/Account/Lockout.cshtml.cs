using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSite.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LockoutModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
