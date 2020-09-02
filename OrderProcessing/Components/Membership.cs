using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Components
{
    public abstract class Membership
    {
        public void SendEmail()
        {
            Console.WriteLine("Send Email");
        }
        abstract public void Run();
    }
}
