
namespace PendingSystem.app.Entities
{
        
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Item { get; set; }

        public double SubTotal()
        {
            double subtotal = Price * Quantity;
            return subtotal;
        }

    }

}