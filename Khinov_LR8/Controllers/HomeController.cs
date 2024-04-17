using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Khinov_LR8.Models;
namespace Khinov_LR8.Controllers
{
    public class HomeController : Controller
    {
        List<ProductsModel> list1 = new List<ProductsModel>()
        {
            new ProductsModel(1, "Classic Burger", 6, new DateOnly(2024, 02, 20)),
            new ProductsModel(2, "Steak Burger", 8, new DateOnly(2024, 03, 27)),
            new ProductsModel(3, "Vegan Burger", 6, new DateOnly(2024, 01, 03)),
            new ProductsModel(4, "Cheeseburger", 7, new DateOnly(2024, 01, 01))
        };
        public IActionResult Index()
        {
            return View(list1);
        }
    }
}
