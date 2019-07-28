﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVCApp.Models.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your name!")]
        [StringLength(70, MinimumLength = 3)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
