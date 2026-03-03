System.Console.WriteLine("Enter account data");
System.Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
System.Console.Write("Holder: ");
string holder = Console.ReadLine();
System.Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine());
System.Console.Write("Withdraw Limit: ");
double limit = double.Parse(Console.ReadLine());

Account c1 = new Account(number, holder, balance, limit);

try
{
    System.Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());
    c1.Withdraw(amount);
}
catch (ArgumentException e)
{
    System.Console.WriteLine("Invalid input: " + e.Message);
}
catch (SaldoInsuficienteException e)
{
    System.Console.WriteLine("Withdraw error: " + e.Message);
}

