using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{
    //concrete upgrade
    public class UpgradeMembership : Membership
    {
        public override bool Run()
        {
            bool returnResult = false;
            try
            {
                returnResult = base.SendEmail();
                if (returnResult)
                {
                    Console.WriteLine("Upgrade Membership");
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
