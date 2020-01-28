using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Employees.Models;

namespace MVC5Employees.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddEmp(int empID, string empName, int empSal)
        {
            Employee e = new Employee()
            {
                Id = empID,
                Name = empName,
                Salary = empSal
            };
            return View("EmpConfirm", e);
        }
        public ActionResult AddEmp()
        {
            return View("NewEmpForm");
        }

        public ActionResult GrossPayCalculator()
        {
            return View();
        }

        public ActionResult mainOfficeEmployees()
        {
            return View();
        }
    }
}