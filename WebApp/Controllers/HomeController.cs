﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //Comments for Index Method...
        public IActionResult Index()
        {
            return View();
        }


        //Comments for Aout method....
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        // Contact page method... 
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
