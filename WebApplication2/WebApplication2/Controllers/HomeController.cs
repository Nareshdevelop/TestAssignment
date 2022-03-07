using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;
        public HomeController(ILogger<HomeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            

           
            List<Employee> employees = SessionHelper.GetObjectFromJson<List<Employee>>(HttpContext.Session, "updatedEmployees");
            if (employees == null || employees.Count == 0)
            {
                employees = _employeeService.GetEmployeeList();
            }


            return View(employees);
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
     
        public ObjectResult Work(int employeeId, int workDays)
        {
            var employeeList = _employeeService.GetUpdatedEmployeeList( employeeId, workDays);
             SessionHelper.SetObjectAsJson(HttpContext.Session, "updatedEmployees", employeeList);

            return Ok(employeeList);
        }
        public ObjectResult TakeVacation(int employeeId, int workDays)
        {
            var employeeList = _employeeService.GetUpdatedVacationDays(employeeId, workDays);
             SessionHelper.SetObjectAsJson(HttpContext.Session, "updatedEmployees", employeeList);
            return Ok(employeeList);
        }
    }
}
