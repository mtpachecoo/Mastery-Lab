using System.Dynamic;

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge{get; set;}

    public OutsourcedEmployee(){}
    
    public OutsourcedEmployee(string name, int hours, double valueperhour , double additionalcharge) 
        : base (name, hours, valueperhour)
    {
        AdditionalCharge = additionalcharge;
    }
}