using Microsoft.AspNetCore.Mvc;
using MvcProjectTracking.Models;

namespace MvcProjectTracking.Controllers
{
    public class EmployeeController : Controller
    {
        //public ViewResult Index() //sadece görünüm olarak geri dönüş sağlar.
        //{
        //    return View();
        //}

        public string Index3() //sayfaya sadece string bir ifade döner ama kayout kullanmaz.
        {
            return "Hello World.";
        }

        public IActionResult Index() //hangi view a gideceğini belirtir ve hangi mesajı view a taşıyacağını belirtir.
        {
            //ViewBag.Message = "Employee";
            var message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2() //View a string array taşır.
        {
            var names = new string[]
            {
                "Ayşe",
                "Ahmet",
                "Veli"
            };
            return View(names);
        }

        public IActionResult Index4()
        {
            var employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Evrim",
                    SurName = "Çalışkan",
                    Age = 26,

                },
                new Employee()
                {
                    Id = 2,
                    Name = "Ahmet",
                    SurName = "Güngör",
                    Age = 30
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Elif",
                    SurName = "Güngörmez",
                    Age = 32
                }
            };
            return View("Index4", employeeList);
        }
    }
}
