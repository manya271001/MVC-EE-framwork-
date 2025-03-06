using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult EmpDelete()
        {
            return View();
        }
        public IActionResult EmpList()
        {
            List<Employee> obj = new List<Employee>
  {
      new Employee {Id=101,firstName="Manya",lastName="Sharma",city="Delhi"},
      new Employee {Id=102,firstName="Shradhha",lastName="Balapurkur",city="Delhi"},
      new Employee {Id=103,firstName="Anshita",lastName="Dilarj",city="Delhi" },
      new Employee {Id=104,firstName="Hrishabh",lastName="Dubey",city="Delhi" },
      new Employee {Id=105,firstName="Akshat",lastName="Sharma",city="Delhi" }
  };
            return View(obj);
        }

    }
}
