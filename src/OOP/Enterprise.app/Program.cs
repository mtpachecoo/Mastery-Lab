Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for ( int i = 0; i < n ; i++)
{
    Console.WriteLine($"Employee #{i+1} data: ");
    Console.Write("Outsourced (y/n)? ");
    if(Console.ReadLine() == "y")
    {
        System.Console.Write("Name: ");
        string name = Console.ReadLine();
        System.Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        System.Console.Write("Value per hour: ");
        double valueperhour = double.Parse(Console.ReadLine());
        System.Console.Write("Additional charge: ");
        double additionalcharge = double.Parse(Console.ReadLine());
        employees.Add(new OutsourcedEmployee(name, hours, valueperhour, additionalcharge));
    }
    else
    {
        System.Console.Write("Name: ");
        string name = Console.ReadLine();
        System.Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        System.Console.Write("Value per hour: ");
        double valueperhour = double.Parse(Console.ReadLine());
        employees.Add(new Employee(name, hours, valueperhour));
    }
}

foreach (Employee l in employees)
{
    System.Console.WriteLine(l);
}
