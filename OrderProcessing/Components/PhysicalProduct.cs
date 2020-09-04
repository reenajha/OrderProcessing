using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Components
{
    public abstract class PhysicalProduct
    {
        public bool GenerateSlip()
        {
            bool returnResult = false;
            try
            {
                returnResult = true;
                Console.WriteLine("Generate Slip");
            }
            catch (Exception)
            {
                //logic to log error
                returnResult = false;
            }
            return returnResult;
        }

        public bool GenerateCommissionPayment()
        {
            bool returnResult = false;
            try
            {
                returnResult = true;
                Console.WriteLine("Generate Commission Payment ");
            }
            catch (Exception)
            {
                //logic to log error
                returnResult= false;

            }
            return returnResult;
        }
        abstract public bool Run();
    }
}
