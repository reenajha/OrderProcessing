using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{
    //concrete product Book
    public class Book : PhysicalProduct
    {
        public override bool Run()
        {
            bool returnResult = false;
            try
            {
                returnResult = base.GenerateSlip();
                if (returnResult)
                {
                    returnResult = base.GenerateCommissionPayment();
                }
                Console.WriteLine("Generate Duplicate Slip");
            }
            catch (Exception)
            {
                //logic to log error
                returnResult = false;
            }
            return returnResult;

        }
    }
}
