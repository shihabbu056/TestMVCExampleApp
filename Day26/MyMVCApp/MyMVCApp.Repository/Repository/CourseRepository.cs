using MyMVCApp.DatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMVCApp.Models.Models;
using System.Data.Entity;

namespace MyMVCApp.Repository.Repository
{
    public class CourseRepository
    {
        StudentDbContext db = new StudentDbContext();
        public bool Add(Course course)
        {
            int isExecuted = 0;

            db.Courses.Add(course);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Delete(Course course)
        {
            int isExecuted = 0;
            Course aCourse = db.Courses.FirstOrDefault(c => c.ID == course.ID);

            db.Courses.Remove(aCourse);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }
        public bool Update(Course course)
        {
            int isExecuted = 0;
            //Method 1
            //Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //if (aStudent != null)
            //{
            //    aStudent.Name = student.Name;
            //    isExecuted = db.SaveChanges();
            //}

            //Method 2
            db.Entry(course).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }
        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }
        public Course GetByID(Course course)
        {
            Course aCourse = db.Courses.FirstOrDefault(c => c.ID == course.ID);
            return aCourse;
        }
    }
}
