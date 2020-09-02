using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Client;
using OrderProcessing.Components;
using OrderProcessing.Models;
using System;

namespace OrderProcessing.Test
{
    [TestClass]
    public class PaymentProcessingTest
    {
        PaymentClient payment;
        [TestMethod]
        public void TestPhysicalProduct()
        {
            try
            {
                payment = new PaymentClient(new Payment(), new Product { category = "physical", type = "book" });
                payment.ProcessOrder();
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
           
            
        }

        [TestMethod]
        public void TestMembership()
        {
            try
            {
                payment = new PaymentClient(new Payment(), new Product { category = "membership", type = "activate" });
                payment.ProcessMembership();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
