using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using PendingSystem.app.Entities.Enums;

namespace PendingSystem.app.Entities
{
       public class Order
    {
       public DateTime Moment { get; set; }
       public OrderStatus Status { get; set; }

       public List<OrderItem> orderItems { get; private set; } = new List<OrderItem>();

       public Order(){}        

       public Order(DateTime moment, OrderStatus status, Client client, List<OrderItem> orderItems)
        {
            Moment = moment;
            Status = status;
            Client = client;
            this.orderItems = orderItems;
        }

        public Client Client { get; set; }
       public void AddItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            orderItems.Remove(orderItem);
        }

        public double Total()
        {
            double soma = 0;
            foreach (OrderItem item in orderItems)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

          public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");

            foreach ( OrdemItem items in orderItems)
            {
                sb.AppendLine(items.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));

            return sb.ToString();
        }

    }
}