using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{

    //concrete Learning Video
    public class LearningVideo : PhysicalProduct
    {

        public override bool Run()
        {
            bool returnResult = false;
            try
            {
                returnResult = base.GenerateSlip();
                if (returnResult)
                {
                    Console.WriteLine("Add First Aid Video");
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
