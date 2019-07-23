using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVC.Models;
//using AnnonymousTypeExample;


namespace TestMVC.DatabaseContext.DatabaseContext
{
    public class DatabaseDbContext:DbContext
    {
        public DatabaseDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}
