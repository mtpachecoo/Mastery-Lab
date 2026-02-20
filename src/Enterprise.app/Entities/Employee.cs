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

    public double Payment()
    {
        return ValuePerHour * Hours;
    } 
}