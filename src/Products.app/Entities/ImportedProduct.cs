

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct(string name, double price, double customsFee) 
        : base(name, price)
    {
        CustomsFee = customsFee;
        Price += CustomsFee;
        
    }

    public double TotalPrice()
    {
        return base.Price + CustomsFee;
        
    }
    public override string PriceTag()
    {
        return Name + " $ " + Price + $" (Customs fee: $ {CustomsFee})" ;
    }

}