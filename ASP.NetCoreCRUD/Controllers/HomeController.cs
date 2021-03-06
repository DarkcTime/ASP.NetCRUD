﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NetCoreCRUD.Models;
using ASP.NetCoreCRUD.Models.Context;
using ASP.NetCoreCRUD.BackEnd.Model;

namespace ASP.NetCoreCRUD.Controllers
{
    public class HomeController : Controller
    {

        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */

        private CollegeContext context; 

        public HomeController(CollegeContext collegeContext)
        {
            this.context = collegeContext; 
             
        }


        public IActionResult Index()
        {
            ContextModel.Context = this.context; 
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
