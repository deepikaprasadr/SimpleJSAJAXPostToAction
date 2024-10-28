using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SimpleJSAJAXPostToAction.Models;
using System.Reflection;

namespace SimpleJSAJAXPostToAction.Pages
{
    public class ModalPopUpModel : PageModel
    {

        public List<Customer> customerlist = new List<Customer>()
       {
           new Customer(){CustomerID="1",ContactName="Sammi",Address="WLaf",Country="USA" },
           new Customer(){CustomerID="2",ContactName="Mohan",Address="Michigan",Country="USA"},
           new Customer(){CustomerID="3",ContactName="Rajan",Address="Madurai",Country="India"}
       };
        //static List<Customer> list = new()
        //        {
        //             new Customer(){ CustomerId = 101, Email = "c@gmail.com", Name = "Mayor1" },
        //            new Customer(){ CustomerId = 102, Email = "c1@gmail.com", Name = "Deepika" }
        //        };

        public void OnGet()
        {
            this.customerlist = (from customer in customerlist.Take(3) select customer).ToList();
        }
        public void OnPostList(string customerId)
        {
            this.customerlist=(from customer in customerlist.Take(3) select customer).ToList();

        }


        public PartialViewResult OnPostDetails(string customerId)
        {
            Customer acustomer=new Customer();
            //acustomer = customerlist.Where(x=>x.CustomerID=="1").select(x => x.CustomerID)//from customer in customerlist.Find 

            //return new PartialViewResult
            //{
            //    ViewName = "Details",
            //    ViewData = new ViewDataDictionary<Customer>(ViewData, this.customerlist.Find(customerId))
            //};

            acustomer=customerlist.Find(x => x.CustomerID==customerId);
            return Partial("Details", acustomer);
        }

        public IActionResult OnPostGetTime(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return new JsonResult(person);
        }




    }
}
