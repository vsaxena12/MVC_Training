using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoggerDemo.Models;

namespace LoggerDemo.Controllers
{
    public class HomeController : Controller
    {
        ILogger _logger;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) //Dependency Injection
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                int a = 5;
                int b = 0;
                int z = a / b;
            }
            catch (Exception e)
            {
                
                _logger.LogError(e.Message);
                _logger.LogInformation("This is the test information for Logging");
                _logger.LogInformation("Next Information");
            }
            //_logger.LogInformation("Log Error   ");
            //_logger.LogError("Log Error");
            //_logger.LogWarning("Add ");

            //using (_logger.BeginScope("Log Scope Example"))
            //{
            //    //Condition
            //    _logger.LogInformation("Begin Scope");
            //    //Condition 2
            //    _logger.LogWarning("Test Scope");

            //}
            //using (_logger.BeginScope("Log Scope Example2"))
            //{
            //    _logger.LogInformation("Begin Scope");
            //    _logger.LogWarning("Test Scope");

            //}

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
