using Microsoft.AspNetCore.Mvc;

namespace B3ans.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
