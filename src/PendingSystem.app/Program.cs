
namespace PendingSystem.app
{
    class Program
    {
        static void Main(string[] args)
        {

         System.Console.WriteLine("Enter client data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client1 = new Client(name, email, birthDate);
            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order1 = new Order(DateTime.Now, status, client1, new List<OrderItem>());  

            System.Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order1.AddItem(orderItem);
            }
            System.Console.WriteLine(order1);
        }
    }
}