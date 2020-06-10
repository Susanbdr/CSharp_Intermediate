using System;
using System.Collections.Generic;
using System.Threading;
using DemoLibrary.Classes;
using DemoLibrary.Interface;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (var prod in cart)
            {
                prod.ShipItem(customer);
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }
        }



        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Susan",
                LastName = "Joshi",
                City = "Omaha",
                EmailAddress = "susanbdrjoshi1@gmail.com",
                PhoneNumber = "555-5555-555"
            };
        }
        private static List<IProductModel> AddSampleData()
        {
            var output = new List<IProductModel>
            {
                new PhysicalProductModel() {Title = "Football"},
                new PhysicalProductModel() {Title = "Hard Drive"},
                new PhysicalProductModel() {Title = "Baseball"},
                new DigitalProductModel() {Title = "E-Book"},
                new CourseProductModel(){Title = ".Net Course"}
            };

            return output;
        }


        
        
    }

   
}
