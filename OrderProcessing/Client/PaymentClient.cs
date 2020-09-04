using OrderProcessing.Components;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Client
{
    public class PaymentClient
    {
        private PhysicalProduct physicalProduct;
        private Membership membership;

        public PaymentClient(IProudctFactory factory, Product product)
        {
            switch (product.category)
            {
                case "physical":
                    physicalProduct = factory.ProcessPhysicalProduct(product);

                    break;
                case "membership":
                    membership = factory.ProcessMembership(product);

                    break;
                default:
                    throw new Exception();
            }


        }

        public bool ProcessOrder()
        {
            bool returnResult = false;
            try
            {
                returnResult = physicalProduct.Run();
            }
            catch (Exception)
            {
                //logic to log error
                returnResult = false;
            }
            return returnResult;


        }

        public bool ProcessMembership()
        {
            bool returnResult = false;
            try
            {
                returnResult = membership.Run();
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
