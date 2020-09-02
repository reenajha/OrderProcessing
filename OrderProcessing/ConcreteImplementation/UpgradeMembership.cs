using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{
    //concrete upgrade
    public class UpgradeMembership : Membership
    {
        public override void Run()
        {
            Console.WriteLine("Upgrade Membership");
            base.SendEmail();
        }
    }
}
