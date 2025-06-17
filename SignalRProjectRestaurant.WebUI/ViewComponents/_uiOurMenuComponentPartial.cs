using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.ViewComponents
{
    public class _uiOurMenuComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
