using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class EmployeeController : Controller
    {
        List<Emp> employees = new List<Emp>();
        // GET: Employee
        public ActionResult GetAllEmployees()
        {
            employees = Emp.getEmps();
            return View(employees);
        }
    }
}