using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{

    //concrete Activate
    public class ActivateMembership : Membership
    {
        public override void Run()
        {
            Console.WriteLine("Activate Membership");
            base.SendEmail();
        }
    }
}
