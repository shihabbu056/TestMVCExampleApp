using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousTypeExample
{
    class Program
    {
        //delegate int CalculatorHandter(int firstNumber, int secondNumber);
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
            var prodects = new List<Product>()
            {
                new Product(){Id=1, Name="Nokia 3310", Price=1000, ProductType="Mobile"},
                new Product(){Id=2, Name="Apple iMac", Price=25000, ProductType="Computer"},
                new Product(){Id=3, Name="Monitor", Price=12000, ProductType="Computer"},
                new Product(){Id=4, Name="Laptop", Price=50000, ProductType="Computer"},
                new Product(){Id=5, Name="Otobi Table", Price=8000, ProductType="Furniture"},
                new Product(){Id=6, Name="Pen", Price=500, ProductType="Stationary"}
            };
            var retriveProductList = from p in prodects
                where p.Price > 2000 && p.Price < 25000
                select new {Name=p.Name, Price=p.Price+" Taka",Code=p.Name+p.Price};
            foreach (var c in retriveProductList)
            {
                Console.WriteLine("Product Name"+"\t\t"+"Product Price"+"\t\tProduct Code"+Environment.NewLine+c.Name+"\t\t"+c.Price+"\t\t"+c.Code);
            }
            //foreach (var c in customer)
            //{
            //    Console.WriteLine("Customer Name : " + c.Name + " ContactNo : " + c.ContactNo + " Code : " + c.Code);
            //}

            //foreach (var stu in cus)
            //{
            //    Console.WriteLine(stu);
            //}

            //Console.ReadKey();
            Func<int, int, int> addMethod = (firstNumber, secondNumber) => firstNumber + secondNumber;
            
                
            int result = addMethod(10, 52);
            //ShowCustomer(customer);
            //Console.WriteLine(result);
            Console.ReadKey();
        }

        static void ShowCustomer(dynamic customer)
        {
            foreach (var cus in customer)
            {
                Console.WriteLine("Id is : "+cus.Id+" Name : "+cus.Name+"ContactNo : "+cus.ContactNo+"Code : "+cus.Code);
            }
        }

        static int Add(int fNumber, int sNumber)
        {
            return fNumber + sNumber;
        }
    }
}
