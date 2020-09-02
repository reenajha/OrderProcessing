using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Components
{
    public abstract class PhysicalProduct
    {
        public void GenerateSlip()
        {
            Console.WriteLine("Generate Slip");
        }

        public void GenerateCommissionPayment()
        {
            Console.WriteLine("Generate Commission Payment ");
        }
        abstract public void Run();
    }
}
