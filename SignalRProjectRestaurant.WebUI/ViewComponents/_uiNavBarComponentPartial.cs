using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.ViewComponents
{
    public class _uiNavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
