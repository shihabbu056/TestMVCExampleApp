﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AnnonymousTypeExample;
using TestMVC.Models;

namespace TestMVC.DatabaseContext.DatabaseContext
{
    public class DatabaseDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
