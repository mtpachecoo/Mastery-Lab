using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using PedingSystem.app.Entities.Enums;

namespace PedingSystem.app.Entities
{
       public class Order
    {
       public DateTime Moment { get; set; }
       public OrderStatus Status { get; set; }

       public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
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
            int soma = 0;
            foreach (OrderItem item in orderItems)
            {
                soma += item.SubTotal();
            }
            return soma;
        }
    }
}