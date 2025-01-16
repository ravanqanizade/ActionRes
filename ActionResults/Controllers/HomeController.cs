using ActionResults.entities;
using ActionResults.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;


namespace ActionResults.Controllers
{
    public class HomeController : Controller
    {


        public string Index()
        {
            return "dxjx";
        }

        public ViewResult Employee1()
        {

            List<Employee> list = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Ravan",
                    LastName = "Qanizade",
                    CityId = 1,
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Bayram",
                    LastName = "Qurbanov",
                    CityId = 2,
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Tofiq",
                    LastName = "Cavadli",
                    CityId = 3,
                },


            };

            return View(list);
        }

        public ViewResult Employee2()
        {

            List<Employee> list = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Ravan",
                    LastName = "Qanizade",
                    CityId = 1,
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Bayram",
                    LastName = "Qurbanov",
                    CityId = 2,
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Tofiq",
                    LastName = "Cavadli",
                    CityId = 3,
                },


            };
            List<string> cities = new List<string>() { "Baku", "London", "Monaco" };


            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                Cities = cities,
                Employees = list,
            };
            var vm = employeeViewModel;
                
                
                return View(list);

        }
    
        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound();
        }

        public IActionResult Index7()
        {
            return Redirect ("/home/employee1");
        }
        public IActionResult Index8()
        {
            return RedirectToAction("employee1");
        }

        public IActionResult Index9()
        {
            var routeValue = new RouteValueDictionary(
                new { action = "employee1", controller = "home" });
            return RedirectToRoute(routeValue);
        }
    
        public JsonResult GetJson()
        {
            List<Employee> list = new List<Employee>()
            {
            new Employee()
            {
                Id = 1,
                FirstName = "Ravan",
                LastName = "Qanizade",
                CityId = 1,
            },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Bayram",
                    LastName = "Qurbanov",
                    CityId = 2,
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Tofiq",
                    LastName = "Cavadli",
                    CityId = 3,
                }

                
            };
            return Json(list);
        }
    }
}