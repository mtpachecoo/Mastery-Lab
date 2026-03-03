
public class Account 
{
    public int Number { get; set; }
    public string Holder { get; set;}
    public double Balance { get; set; }
    public double Limit { get; set; }

    public Account(){}

    public Account(int number, string holder, double balance, double limit)
    {
        if (string.IsNullOrEmpty(holder))
            throw new ArgumentException("Holder cannot be empty");

        if (balance < 0)
            throw new ArgumentException("The first balance cannot be negative.");

        if (limit < 0)
            throw new ArgumentException("The withdrawal limit cannot be negative.");

        Number = number;
        Holder = holder;
        Balance = balance;
        Limit = limit; 
    }

    public void Deposit(double deposit)
    {
        Balance += deposit;
    }   

    public void Withdraw(double value)
    {
        if(value <= 0)
        {
            throw new ArgumentException("Valor do saque deve ser positivo");
        }
        if(value > Limit)
        {
            throw new ArgumentException("The amount exceeds the withdrawal limit.");
        }

        if(value > Balance)
        {
            throw new SaldoInsuficienteException(Balance);
        }

        Balance -= value;
        System.Console.WriteLine("New balance: " + Balance);

    }


}