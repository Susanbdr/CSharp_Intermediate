using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Interface
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
