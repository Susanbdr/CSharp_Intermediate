using System;
using System.Collections.Generic;
using System.Text;
using DemoLibrary.Classes;

namespace DemoLibrary.Interface
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderedBeenCompleted { get; }

        void ShipItem(CustomerModel customer);

    }
}
