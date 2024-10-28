using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;
using SimpleJSAJAXPostToAction.Models;

namespace SimpleJSAJAXPostToAction.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        //error could be bcos returntype is not specific ie.JSONResutl

        public IActionResult OnPostGetAjax(string name)
        {
            return new JsonResult("Hello" + name);
        }


        [HttpPost]
        public IActionResult OnPostAddStudent(Student student)
        {
            return new JsonResult(student);
        }




    }
}
