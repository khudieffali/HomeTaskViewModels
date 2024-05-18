using HomeTaskViewModels.Models;
using HomeTaskViewModels.Models.DataAccess;
using HomeTaskViewModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HomeTaskViewModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ViewDbContext _context;
        public HomeController(ViewDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            List<Features> features= [.. _context.Features];

            Slider? slider = _context.Slider.FirstOrDefault();

            List<Products> productList= [.. _context.Products];

            List<Categories> categories= [.. _context.Categories];

            HomeVM vm = new() { Features = features,Slider=slider,ProductList=productList,Categories=categories};
            return View(vm);
        }
    }
}
