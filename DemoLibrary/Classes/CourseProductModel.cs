using System;
using System.Collections.Generic;
using System.Text;
using DemoLibrary.Interface;

namespace DemoLibrary.Classes
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderedBeenCompleted { get; private set; }
        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderedBeenCompleted == false)
            {
                Console.WriteLine($"Added the { Title } to { customer.FirstName }'s account");
                HasOrderedBeenCompleted = true;
            }
        }
    }
}
