﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRProjectRestaurant.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
