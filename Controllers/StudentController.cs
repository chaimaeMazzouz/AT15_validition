using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AT15_validation.Models;

namespace AT15_validation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        List<Student> studentList = new List<Student>()
        {
            new Student
            {
                StudentId = 1,
                StudentName = "Mazzouz",
                Age = 21
            },
            new Student
            {
                StudentId = 2,
                StudentName = "Alaoui",
                Age = 21
            }
        };
        public ActionResult Index()
        {
            return View(studentList);
        }
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            { //write code to update student
                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}