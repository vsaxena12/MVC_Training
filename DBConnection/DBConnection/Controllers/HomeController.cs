using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DBConnection.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DBConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand con = new SqlCommand("select * from Logs");
            //var count = con.ExecuteScalar();
            //ViewData["TotalData"] = count;

            connection.Close();
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
