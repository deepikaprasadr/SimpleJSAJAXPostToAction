using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleJSAJAXPostToAction.Models;

namespace SimpleJSAJAXPostToAction.Pages
{
    public class GetTimeAntiForgeryKeyModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostGetTime(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime =DateTime.Now.ToString()
            };
            return new JsonResult(person);

        }
    }
}
