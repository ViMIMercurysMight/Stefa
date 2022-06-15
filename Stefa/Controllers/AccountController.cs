using Microsoft.AspNetCore.Mvc;

namespace Stefa.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
