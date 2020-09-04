using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Client;
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
                bool result = OrderProcessing.Program.StartOrderProcessing(1, "physical", "book");
                Assert.AreEqual(result, true);
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
                bool result = OrderProcessing.Program.StartOrderProcessing(2, "membership", "activate");
                Assert.AreEqual(result, true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
