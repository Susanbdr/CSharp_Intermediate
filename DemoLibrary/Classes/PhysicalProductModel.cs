using System;
using System.Collections.Generic;
using System.Text;
using DemoLibrary.Interface;

namespace DemoLibrary.Classes
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderedBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderedBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderedBeenCompleted = true;
            }
        }
    }
}
