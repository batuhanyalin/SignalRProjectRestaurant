using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.ViewComponents
{
    public class _uiFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
