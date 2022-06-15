using Microsoft.AspNetCore.Mvc;

namespace Stefa.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
