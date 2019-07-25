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
        public string Add(Student student)
        {
            //_student.ID = 101;
            _student.Name = student.Name;
            _student.Address = student.Address;
            _student.Age = student.Age;
            _studentManager.Add(_student);
            return "Added";
        }
        public ActionResult Delete(int id)
        {
            _student.ID = id;
            _studentManager.Delete(_student);
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