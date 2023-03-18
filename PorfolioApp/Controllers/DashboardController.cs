﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.V1 = "Dashboard";
            ViewBag.V2 = "İstatistikler";
            ViewBag.V3 = "İstatistik Sayfası";
            return View();
        }
    }
}