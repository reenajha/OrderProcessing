using OrderProcessing.Components;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Interfaces
{
    public interface IProudctFactory
    {
        PhysicalProduct ProcessPhysicalProduct(Product product);
        Membership ProcessMembership(Product product);
    }
}
