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
            PaymentClient payment;

            Console.WriteLine("\r\n------------This is Order Processing Application----------------");
            payment = new PaymentClient(new Payment(), new Product { category = "physical", type = "book" });
            payment.ProcessOrder();

            payment = new PaymentClient(new Payment(), new Product { category = "membership", type = "activate" });
            payment.ProcessMembership();

            Console.ReadLine();
        }
    }
}
