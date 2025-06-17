using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
