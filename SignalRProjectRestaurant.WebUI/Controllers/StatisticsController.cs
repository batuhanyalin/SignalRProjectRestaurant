﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
