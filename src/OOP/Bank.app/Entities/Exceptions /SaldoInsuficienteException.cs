public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(double balance)
        : base($"The amount exceeds the withdrawal limit. Current balance: {balance}")
    { }
}