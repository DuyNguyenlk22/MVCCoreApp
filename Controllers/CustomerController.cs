using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class CustomerController : Controller
    {
        [Route("khach-hang")]
        public string Index()
        {
            return "Hello from customerController";
        }
    }
}
