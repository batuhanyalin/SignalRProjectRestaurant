using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.ViewComponents
{
    public class _uiBookTableComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
