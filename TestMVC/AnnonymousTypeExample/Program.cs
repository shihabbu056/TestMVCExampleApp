using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using TestMVC.Models;

namespace AnnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> cus = new List<Student>()
            {
                 new Student(){StudentId = 01, FirstName = "Md. Shihab", LastName = "Uddin", RollNo = 2154, Email = "shihab@yahoo.com", Contact = 01741228876},
                 new Student(){StudentId = 02, FirstName = "Md. Elius", LastName = "Hossain", RollNo = 2154, Email = "elisuhossain@yahoo.com", Contact = 01866951319}
            };
            
            var customer = new[]
            {
                new {Id = 101, Name = "Md. Shihab Uddin", ContactNo="01741228876", Code="Cus-54210"}
            };
            ////foreach (var c in customer)
            ////{
            ////    Console.WriteLine("Customer Name : "+c.Name+" ContactNo : "+c.ContactNo+" Code : "+c.Code);
            ////}

            ////foreach (var stu in cus)
            ////{
            ////    Console.WriteLine(stu);
            ////}

            ////Console.ReadKey();
            ShowCustomer(customer);
            Console.ReadKey();
        }

        static void ShowCustomer(dynamic customer)
        {
            foreach (var cus in customer)
            {
                Console.WriteLine("Id is : "+cus.Id+" Name : "+cus.Name+"ContactNo : "+cus.ContactNo+"Code : "+cus.Code);
            }
        }
    }
}
