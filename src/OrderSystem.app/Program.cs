using OrderSystem.Entities;
using OrderSystem.Entities.Enums;
using System;

namespace OrderSystem.app
{
    class Program
    {
        static void Main(string[] args)
        {
           Order order = new Order
           {
               Id = 12026,
               Moment = DateTime.Now,
               Status = OrderStatus.PendingPayment
           };

            Console.WriteLine(order);
        }
    }
}