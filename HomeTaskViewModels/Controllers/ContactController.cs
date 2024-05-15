using HomeTaskViewModels.Models;
using HomeTaskViewModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeTaskViewModels.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            Contacts contact = new()
            {
                TopTitle = "Contact Us",
                Title = "Yig bizi",
                Description = "salamsalam salam salam salam salam salam",
                Address = "Baku,Azerbaijan",
                PhoneNumber = "+994553053232",
                Email = "ali@gmail.com"
            };
            ContactVM vm = new() { Contact = contact };
            return View(vm);
        }
    }
}
