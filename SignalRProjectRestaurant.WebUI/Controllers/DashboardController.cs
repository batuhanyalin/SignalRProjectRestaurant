﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
