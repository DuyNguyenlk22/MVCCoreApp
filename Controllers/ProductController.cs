using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        public List<ProductModel> products = [
                new () {Id = 1 , Name = "Product 1" , Available = true , Price = 100000 , PromotionPrice = 20000},
                new () {Id = 2 , Name = "Product 2" , Available = false , Price = 200000 , PromotionPrice = 2000}
        ];
        public IActionResult Index()
        {
            return Json(products);
            //return View(products);
        }
    }
}
