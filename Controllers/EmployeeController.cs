using Microsoft.AspNetCore.Mvc;
using Asim_WebApplication1.Models;

namespace Asim_WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        Employee emp1 = new Employee()
        {
            Id = 202,
            Name = "Shyam"
        };
        public IActionResult Details()
        {
            ViewData["id"] = 101;
            ViewData["name"] = "hari";
            ViewBag.id = 102;
            ViewBag.empname = "Ram";
            return View(emp1);
        }

        public IActionResult CreateRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRecord(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return View("Details", emp);
            }
            else
            {
                return View(emp);
            }
            
        }
    }
}
