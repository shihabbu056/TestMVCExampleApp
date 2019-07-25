using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.BLL.BLL;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Controllers
{
    public class CourseController : Controller
    {
        CourseManager _courseManager = new CourseManager();
        private Course _course = new Course();

        // GET: Student
        public string Add(Course course)
        {
            //_student.ID = 101;
            _course.Name = course.Name;
            _course.Code = course.Code;
            _course.Duration = course.Duration;
            _courseManager.Add(_course);
            return "Added";
        }
        public ActionResult Delete(int id)
        {
            _course.ID = id;
            _courseManager.Delete(_course);
            return View();
        }
        public ActionResult Update(Course course)
        {
            _course.ID = course.ID;
            //Method 1

            //_student.Name = "Kamal";
            //_studentManager.Update(_student);

            Course aCourse = _courseManager.GetByID(_course);
            if (aCourse != null)
            {
                aCourse.Duration = course.Duration;
                _courseManager.Update(aCourse);

            }

            return View();
        }
    }
}