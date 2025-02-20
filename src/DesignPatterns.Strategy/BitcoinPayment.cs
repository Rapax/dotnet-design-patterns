namespace DesignPatterns.Strategy;

public class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Bitcoin.");
    }
}