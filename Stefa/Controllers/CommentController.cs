using Microsoft.AspNetCore.Mvc;

namespace Stefa.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
