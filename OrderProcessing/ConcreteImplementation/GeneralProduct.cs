using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{
    
    //concrete product 
    public class GeneralProduct : PhysicalProduct
    {

        public override void Run()
        {
            base.GenerateSlip();
            base.GenerateCommissionPayment();
        }
    }
}
