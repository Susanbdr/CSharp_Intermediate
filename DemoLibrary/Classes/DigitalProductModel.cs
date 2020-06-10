using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using DemoLibrary.Interface;

namespace DemoLibrary.Classes
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        public bool HasOrderedBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderedBeenCompleted == false) 
            {
                Console.WriteLine($"Simulating email { Title } to { customer.FirstName } in { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderedBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
