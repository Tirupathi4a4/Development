using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Help_Class_Sample.Models;

namespace Help_Class_Sample.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private static StudentRecord StudentData = new StudentRecord();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult GetUsers()
        {
            return View(StudentData.lstStudentData.ToList());
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult CreateUser([Bind(Include = "UserName,Mobile,email")] Student studentInfo)
        {
            if (ModelState.IsValid)
            {
                StudentData.AddUser(studentInfo);
                return RedirectToAction("GetUsers");
            }
            return View(studentInfo);
        }

        [HttpGet]
        public ActionResult EditUser(string userName)
        {
            Student student = StudentData.GetUser(userName);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult EditUser([Bind(Include = "UserName,Mobile,email")] Student studentInfo)
        {
            if (ModelState.IsValid)
            {
                StudentData.EditUser(studentInfo);
                return RedirectToAction("GetUsers");
            }
            return View(studentInfo);
        }

    }
}