
namespace PendingSystem.app.Entities
{
        
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Item { get; set; }

        public OrderItem() { }
        public OrderItem(int quantity, double price, Product item)
        {
            Quantity = quantity;
            Price = price;
            Item = item;
        }


        public double SubTotal()
        {
            double subtotal = Price * Quantity;
            return subtotal;
        }

        public override string ToString()
        {
            return Item.ProductName
                + ", $"
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2");
        }



    }

}