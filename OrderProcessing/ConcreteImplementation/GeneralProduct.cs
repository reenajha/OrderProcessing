using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{

    //concrete product 
    public class GeneralProduct : PhysicalProduct
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
