using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Content()
        {
            ViewBag.imgPath = "https://st2.depositphotos.com/3889193/6374/i/600/depositphotos_63744923-stock-photo-beautiful-young-student-posing.jpg";
            ViewBag.content = "That is Student";
            return View();
        }


        public ActionResult StudentList()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student(1, "Vinh", 18));
            students.Add(new Student(2, "Nguyễn", 20));

            ViewBag.studentList = students;

            return View();
        }

        public ActionResult StudentDetail()
        {
            ViewBag.id = 123;
            ViewBag.name = "Vinh";
            ViewBag.age = 18;

            ViewData["GPA"] = 9.5;

            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("Action Search");
        }
    }
}