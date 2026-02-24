

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct(string name, double price, double customsFee) 
        : base(name, price)
    {
        base.Price += CustomsFee;
        CustomsFee = customsFee;
    }

    public double TotalPrice()
    {
        return base.Price + CustomsFee;
        
    }
    public override string PriceTag()
    {
        return base.PriceTag() + "Customs fee: $ " + CustomsFee ;
    }

}