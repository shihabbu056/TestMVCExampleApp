using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using TestMVC.Models;

namespace TestMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Add()
        //{
        //    return View();
        //}

        public ActionResult Update(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update()
        {
            return View();
        }

        public ActionResult ConfirmDelete()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            return View();
        }

        public ActionResult GetById(int? id)
        {
            return View();
        }
        public ActionResult GetAll()
        {
            return View();
        }
    }
}