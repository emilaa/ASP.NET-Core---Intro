using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core___Practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string FullData(string name, string surname, int age)
        {
            return $"Name-{name}: Surname-{surname}-{age}";
        }
    }
}
