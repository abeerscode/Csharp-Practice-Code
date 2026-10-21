
using Entities;
using Facade;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentFacade facade = new StudentFacade();

            List<Student> students = facade.GetStudents();

            return View(students);
        }
    }
}
