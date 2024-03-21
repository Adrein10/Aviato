using Microsoft.AspNetCore.Mvc;
namespace Aviato.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add_Product()
        {
            return View();
        }
    }
}
