using System;
using Microsoft.AspNet.Mvc;
using MVAMVC.Models;

namespace MVAMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET /HOME/ABOUT
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Here is a person.";

            var person = new Person()
            {
                first_name = "Paul",
                surname = "Allen",
                birthdate = new DateTime(1990,2,25)
            };

            return View(person);
        }

        [HttpPost]
        public IActionResult About(Person person)
        {
            return View(person);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
