using System.Linq;
using CourseRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegister.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Details(){
            var course=new Course(); 
            course.CourseName="C#";
            course.CourseDetails="Contains beginner to advanced C# lessons.";
            course.isPublish=true;
            return View(course);
        }
        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Apply(Students students)
        {
            if (ModelState.IsValid) {
                Repository.AddStudent(students);
                return View("Thanks",students);
            }
            else{
                return View(students);
            }

        }
        public IActionResult List()
        {
            var students=Repository.Students.Where(i=>i.IsConfirm==true);
             return View(students);
        }
    }
}