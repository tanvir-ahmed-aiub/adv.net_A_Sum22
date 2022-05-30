using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++) {
                /*
                 * Student s = new Student();
                 * s.Id = i+1;
                 * s.Name = "Student " + (i+1),
                 * s.Dob = "";
                 * students.Add(s);
                 */
                students.Add(new Student()
                {
                    Id = i+1,
                    Name = "Student " + (i+1),
                    Dob = "11-11-11"
                });
            }
            return View(students);
        }
        public ActionResult Info() {
            Student s1 = new Student() { 
                Id = 1,
                Name = "Tanvir",
                Dob = "111-111-1"
            };
            return View(s1);
        }
    }
}