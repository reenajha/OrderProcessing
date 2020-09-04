using OrderProcessing.Client;
using OrderProcessing.Components;
using OrderProcessing.Models;
using System;

namespace OrderProcessing
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool returnResult = false;
            Console.WriteLine("\r\n------------This is Order Processing Application----------------");
            Console.WriteLine("Do you want to Order the proudct or Activate Membership");
            var options = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Category");
            var category = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Product Type");
            var productType = Console.ReadLine().ToLower();

            returnResult=StartOrderProcessing(options, category, productType);

            if (returnResult)
            {
                Console.WriteLine("Your order processed");
            }
            else
            {
                Console.WriteLine("Error while processing order");
            }
        }

        public static Boolean StartOrderProcessing(int option,string category,string productType)
        {
            bool returnResult = false;
            PaymentClient payment;

            switch(option)
            {
                case 1:
                    payment = new PaymentClient(new Payment(), new Product { category = category, type = productType });
                    returnResult= payment.ProcessOrder();
                    break;
                case 2 :
                    payment = new PaymentClient(new Payment(), new Product { category = category, type = productType });
                    returnResult=payment.ProcessMembership();
                    break;

                default: Console.WriteLine("Please choose correct option");
                    returnResult = false;
                    break;
            }         
            return returnResult;
        }
    }

   
}
