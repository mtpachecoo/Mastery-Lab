public class Product
{
    public string Name { get; set; }
    public decimal Price { get; private set; }
    public Category Category { get; private set; }

    public Product()
    {
    }
    public Product(string name, decimal price, Category category)
    {
        if (price < 0)
        {
            throw new ArgumentException("Price cannot be negative.");
        }

        Name = name;
        Price = price;
        Category = category;
    }

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
    }

    public void UpdateCategory(Category newCategory)
    {
        Category = newCategory;
    }

    public override string ToString()
    {
        return Name + " "+ Price +" " + Category;
    }
}