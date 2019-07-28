using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.BLL.BLL;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager =new StudentManager();
        private Student _student = new Student();

        // GET: Student
        [HttpGet]
        public ActionResult Add()
        {
            return View(_studentManager.GetAll());
        }
        [HttpPost]
        public ActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                if (_studentManager.Add(student))
                {
                    ViewBag.SuccessMsg = "Saved.";
                }
                else
                {
                    ViewBag.FailMsg = "Vailed!";
                }
            }
            else
            {
                ViewBag.FailMsg= "Validation Error!";
            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            _student.ID = id;
            var student = _studentManager.GetByID(_student);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                if (_studentManager.Update(student))
                {
                    ViewBag.SuccessMsg = "Update Successfully.";
                }
                else
                {
                    ViewBag.FailMsg = "Update Vailed!";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Error!";
            }

            return View(student);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            _student.ID = id;
            var student = _studentManager.GetByID(_student);
            return View(student);
        }
        [HttpPost]
        public ActionResult Delete(Student student)
        {
            
            if (_studentManager.Delete(student))
            {
                ViewBag.DeleteConform = "Student delete conform.";
            }
            return View();
        }
        public ActionResult Update(Student student)
        {
            _student.ID = student.ID;
            //Method 1
            
            //_student.Name = "Kamal";
            //_studentManager.Update(_student);

            Student aStudent = _studentManager.GetByID(_student);
            if (aStudent != null)
            {
                aStudent.Age = student.Age;
                _studentManager.Update(aStudent);
                
            }

            return View();
        }


    }
}