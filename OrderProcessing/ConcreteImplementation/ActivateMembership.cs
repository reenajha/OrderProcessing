using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{

    //concrete Activate
    public class ActivateMembership : Membership
    {
        public override bool Run()
        {
            bool returnResult = false;
            try
            {
                Console.WriteLine("Activate Membership");
                returnResult = base.SendEmail();
            }
            catch (Exception ex)
            {
                //logic to log error
                returnResult = false;
            }
            return returnResult;
        }
    }
}
