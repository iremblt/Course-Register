using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegister.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            int time= DateTime.Now.Hour;
            ViewBag.Greeting=time>12?"Have a nice day":"Good morning";
            ViewBag.UserName="İrem";
            return View();
        }
        public IActionResult About(){
            return View();
        }
    }
}