using System.Net.Http.Headers;


System.Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for ( int i = 1 ; i <= n ; i++)
{
    System.Console.WriteLine($"Product #{i} data:");
    System.Console.Write("Common, used or imported (c/u/i)? ");
    char typeProduct = char.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    switch (typeProduct)
    {
        case 'c':
            {
                products.Add(new Product(name, price));
                break;
            }
        case 'u':
            {
                System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                products.Add(new UsedProduct(name, price, manufactureDate));
                break;
            }
        
        case 'i':
            {
                System.Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine());
                products.Add(new ImportedProduct(name, price, customsFee));
                break;
            }
    }
}

System.Console.WriteLine("PRICE TAGS:");
foreach(Product p in products)
{
    System.Console.WriteLine(p.PriceTag());
}   