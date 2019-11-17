using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplicationSessionImplementation.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Details = HttpContext.Session.GetString("TestSession");
            return View();
        }
    }
}