﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Mvc;
using HTF2018.Models;

namespace HTF2018.Controllers
{
    public class HomeController : Controller
    {
        private readonly ChallengeService _challengeService;

        public HomeController()
        {
            _challengeService = new ChallengeService(new HackTheFutureApi());
        }
        public IActionResult Index()
        {
            
            _challengeService.ExecuteAllChallenges();
            var test = _challengeService.GetAllStates();
            return View(test);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
