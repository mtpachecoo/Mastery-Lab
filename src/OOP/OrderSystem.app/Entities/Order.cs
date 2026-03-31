using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Order ID: {Id}, Moment: {Moment}, Status: {Status}";
        }
    }
}