﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using consumeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace consumeAPI.Controllers
{
    public class EmployeesController : Controller
    {        
        HttpClient client = new HttpClient();

        public async Task<List<Employees>> GetAllEmployee()
        {
            client.BaseAddress = new Uri("http://localhost:56170/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //List<Employees> empList = new List<Employees>();
            HttpResponseMessage response = await client.GetAsync("api/employees");

            if (response.IsSuccessStatusCode)

                return (await response.Content.ReadAsAsync<List<Employees>>());
            else
                return null;
        }

        public async Task<List<Employees>> Details(Employees emp)
        {
            client.BaseAddress = new Uri("http://localhost:56170/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //List<Employees> empList = new List<Employees>();
            HttpResponseMessage response = await client.GetAsync("api/employees");

            if (response.IsSuccessStatusCode)
                return (await response.Content.ReadAsAsync<List<Employees>>());
            else
                return null;
        }


        public async Task<int> Edit(Employees emp)
        {
            client.BaseAddress = new Uri("http://localhost:56170/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //List<Employees> empList = new List<Employees>();
            HttpResponseMessage response = await client.GetAsync("api/employees");

            if (response.IsSuccessStatusCode)

                return (emp.id);
            else
                return 0;

            //return View(List<Employees>);
        }


        public async Task<int> AddEmployee(Employees emp)
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

        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56170/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("api/employees" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
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
        public async Task<ActionResult> Create(Employees employees)
        {
            var res = await AddEmployee(employees);
            if (res > 0)
                return RedirectToAction("Index");
            else
                return View();
        }

        
    }
}