using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{
    //concrete product Book
    public class Book : PhysicalProduct
    {
        public override void Run()
        {
            base.GenerateSlip();
            base.GenerateCommissionPayment();
            Console.WriteLine("Generate Duplicate Slip");
        }
    }
}
