using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnnonymousTypeExample
{
    public class Student{
        
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long RollNo { get; set; }
        public long Contact { get; set; }
    }
}