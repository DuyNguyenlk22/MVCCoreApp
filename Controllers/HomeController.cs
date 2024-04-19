using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var model = new IndexModel
            {
                Message = "Hello from HomeController , Id: " + id
            };
            return View(model);
        }
    }
}
