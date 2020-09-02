using OrderProcessing.ConcreteImplementation;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Components
{
    public class Payment : IProudctFactory
    {
        public PhysicalProduct ProcessPhysicalProduct(Product product)
        {
            switch (product.type)
            {
                case "book":
                    return new Book();
                case "video":
                    return new GeneralProduct();
                case "learningvideo":
                    return new LearningVideo();
                default:
                    throw new Exception();
            }
        }

        public Membership ProcessMembership(Product product)
        {
            switch (product.type)
            {
                case "activate":
                    return new ActivateMembership();
                case "upgrade":
                    return new UpgradeMembership();
                default:
                    throw new Exception();
            }


        }
    }
}
