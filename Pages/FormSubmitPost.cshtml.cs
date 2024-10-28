using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleJSAJAXPostToAction.Pages
{
    public class FormSubmitPostModel : PageModel
    {
        public IActionResult AddStudent(string name)
        {
            return new JsonResult("Hello" + name);
        }
    }
}
