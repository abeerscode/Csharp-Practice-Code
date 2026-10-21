using System.Security.Cryptography.X509Certificates;
using Entities;
using Facade;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            TeacherFacade facade = new TeacherFacade();

            List<Teacher> teachers = facade.GetTeachers();

            return View(teachers);
        }
    }
}