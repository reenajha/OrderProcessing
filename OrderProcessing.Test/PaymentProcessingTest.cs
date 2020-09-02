using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Client;
using OrderProcessing.Components;
using OrderProcessing.Models;

namespace OrderProcessing.Test
{
    [TestClass]
    public class PaymentProcessingTest
    {
        PaymentClient payment;
        [TestMethod]
        public void TestPhysicalProduct()
        {             
            payment = new PaymentClient(new Payment(), new Product { category = "physical", type = "book" });
            payment.ProcessOrder();
            
        }

        [TestMethod]
        public void TestMembership()
        {
            payment = new PaymentClient(new Payment(), new Product { category = "membership", type = "activate" });
            payment.ProcessMembership();
        }
    }
}
