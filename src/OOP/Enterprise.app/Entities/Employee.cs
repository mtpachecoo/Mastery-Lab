using System.Text;

public class Employee
{
    public string Name{get; set;}
    public int Hours{get; set;}
    public double ValuePerHour{get; set;}

    public Employee(){}

    public Employee(string name, int hours, double valueperhour)
    {
        Name = name;
        Hours = hours;
        ValuePerHour = valueperhour;
    }

    public virtual double CalculateSalary()
    {
        return ValuePerHour * Hours;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(" ");
        sb.AppendLine("PAYMENTS: ");
        sb.Append(Name);
        sb.Append( " = $ " + CalculateSalary().ToString("F2")); 
        return sb.ToString();
    }
}
