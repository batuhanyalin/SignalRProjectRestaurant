using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.ViewComponents
{
    public class _uiAboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
