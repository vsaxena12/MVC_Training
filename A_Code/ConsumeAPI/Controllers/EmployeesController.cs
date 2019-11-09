using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConsumeAPI.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsumeAPI.Controllers
{
    public class EmployeesController : Controller
    {
        HttpClient client = new HttpClient();

        public async Task<List<Employee>> GetAllEmployee()
        {
            client.BaseAddress = new Uri("http://localhost:56170/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            List<Employee> empList = new List<Employee>();
            HttpResponseMessage response = await client.GetAsync("api/employees");

            if (response.IsSuccessStatusCode)

                return (await response.Content.ReadAsAsync<List<Employee>>());
            else
                return null;


        }

        public async Task<int> AddEmployee(Employee emp)
        {
            client.BaseAddress = new Uri("http://localhost:56170/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync("api/employees", emp);

            if (response.IsSuccessStatusCode)

                return (emp.id);
            else
                return 0;


        }

        public async Task<ActionResult> Index()
        {
            var data = await GetAllEmployee();

            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Employee employees)
        {
            var res = await AddEmployee(employees);
            if (res > 0)
                return RedirectToAction("Index");
            else
                return View();
        }

    }
}


