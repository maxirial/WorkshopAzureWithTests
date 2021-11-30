using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAzure.Managers;
using WorkshopAzure.Models;

namespace WorkshopAzure.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Employees"] = new EmployeeManager().GetEmployees();
            return View();
        }
    }
}
