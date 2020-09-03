using OrderProcessing.Client;
using OrderProcessing.Components;
using OrderProcessing.Models;
using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("\r\n------------This is Order Processing Application----------------");
            Console.WriteLine("Do you want to Order the proudct or Activate Membership");
            var options =  int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Category");
            var category = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Proudct Type");
            var productType = Console.ReadLine().ToLower();

            StartOrderProcessing(options, category, productType);
        }

        public static Boolean StartOrderProcessing(int option,string category,string productType)
        {
            PaymentClient payment;

            switch(option)
            {
                case 1:
                    payment = new PaymentClient(new Payment(), new Product { category = category, type = productType });
                    payment.ProcessOrder();
                    break;
                case 2 :
                    payment = new PaymentClient(new Payment(), new Product { category = category, type = productType });
                    payment.ProcessMembership();
                    break;

                default: Console.WriteLine("Please choose correct option");
                    break;
            }         

            Console.ReadLine();

            return true;
        }
    }

   
}
