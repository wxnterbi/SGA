using Microsoft.AspNetCore.Mvc;

namespace SGA.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
