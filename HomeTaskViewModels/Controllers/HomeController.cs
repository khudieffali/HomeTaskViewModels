using HomeTaskViewModels.Models;
using HomeTaskViewModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HomeTaskViewModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Features
            List<Features> features = [new() {Id=1, Path = "featured-01.png", Title = "User Storage" },
            new() {Id=2, Path = "featured-02.png", Title = "Free Easy" },
            new() {Id=3, Path = "featured-02.png", Title = "Free Easy" }];

            //Slider
            Slider slider = new()
            {
                Id=1,
                TopTitle = "GTA V",
                Title = "Battlegrounds",
                Description = "BattlegroundsBattlegroundsBattlegroundsBattlegroundsBattlegroundsBattlegroundsBattlegrounds",
                Image = "banner-image.jpg",
                Price =100,
                Discount=45
            };
            //Category Add
            List<Categories> categories = [ new() { Id = 1, Name = "Adventure" },
             new() { Id = 2, Name = "Battle" }];
            

            //Trending Games, MostPopularity Games
            List<Products> productList = [new() {Id=1, Name = "Pubg", Description = "Best Games",ImagePath="trending-01.jpg",Price=50,IsDiscount=true,DiscountPrice=30,ViewCount=5,Raiting=3,CategoryId=1},
            new(){ Id = 2, Name = "CallofDuty", Description = "Best Games",ImagePath="trending-02.jpg",Price = 100,IsDiscount = false,ViewCount = 8,Raiting=8,CategoryId=2 },
            new(){ Id = 3, Name = "GTA V", Description = "Best Games",ImagePath="trending-03.jpg",Price = 70,IsDiscount = true,DiscountPrice=50,ViewCount = 10,Raiting=15,CategoryId=2}];


            HomeVM vm = new() { Features = features,Slider=slider,ProductList=productList,Categories=categories};
            return View(vm);
        }
    }
}
