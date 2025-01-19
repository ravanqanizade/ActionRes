using ActionResults.entities;
using ActionResults.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ActionResults.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Baku", Value="1"},
                    new SelectListItem {Text = "Monaco", Value="2"},
                    new SelectListItem {Text = "Roma", Value="3"},
                    new SelectListItem {Text = "London", Value="4"},

                }
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel) 
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new entities.Employee(),
                

            };
            return View(vm);
        }
    }
}
