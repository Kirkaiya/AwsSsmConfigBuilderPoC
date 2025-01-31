using Microsoft.AspNetCore.Mvc.RazorPages;

namespace converted.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; } = "Your application description page.";

        public void OnGet()
        {
        }
    }
}