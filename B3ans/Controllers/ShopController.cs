using Microsoft.AspNetCore.Mvc;

namespace B3ans.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
