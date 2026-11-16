using Microsoft.AspNetCore.Mvc;

namespace B3ans.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
