using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Components
{
    public abstract class Membership
    {
        public bool SendEmail()
        {
            bool returnResult = false;
            try
            {
                returnResult = true;
                Console.WriteLine("Send Email");
            }
            catch (Exception)
            {
                //logic to log error
                returnResult = false;
            }
            return returnResult;
        }
        abstract public bool Run();
    }
}
