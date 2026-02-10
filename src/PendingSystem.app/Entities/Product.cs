using System;
using System.Collections.Generic;
using System.Linq;


namespace PendingSystem.app.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public double PriceProduct { get; set; }
        
        public Product() { }

        public Product(string productName, double priceProduct)
        {
            ProductName = productName;
            PriceProduct = priceProduct;
        }


    }
}