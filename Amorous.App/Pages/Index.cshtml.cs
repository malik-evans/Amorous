using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Amorous.App.Pages
{
    public class Index : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("Home/Index");
        }
    }
}
