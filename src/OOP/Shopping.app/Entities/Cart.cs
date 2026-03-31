using System.Text;

public class Cart
{
    public List<Product> Products { get; private set; } = new List<Product>();
    public decimal TotalPrice { get; private set; }
    
    public Cart()
    {
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalPrice += product.Price;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (Product items in Products)
        {
            sb.Append(items.ToString()).Append("\n");
        }
        return sb.ToString();

        
    }
}