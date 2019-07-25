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
        public string Add()
        {
            //_student.ID = 101;
            _student.Name = "Ali";
            _student.Address = "Ali";
            _student.Age = 20;
            _studentManager.Add(_student);
            return "Added";
        }
        public ActionResult Delete()
        {
            _student.ID = 1;
            _studentManager.Delete(_student);
            return View();
        }
        public ActionResult Update()
        {
            _student.ID = 3;
            //Method 1
            
            //_student.Name = "Kamal";
            //_studentManager.Update(_student);

            Student aStudent = _studentManager.GetByID(_student);
            if (aStudent != null)
            {
                aStudent.Name = "Zamal";
                _studentManager.Update(aStudent);
                
            }

            return View();
        }


    }
}