using Microsoft.AspNetCore.Mvc.RazorPages;

namespace converted.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; } = "Your contact page.";

        public void OnGet()
        {
        }
    }
}