// See https://aka.ms/new-console-template for more information

using DesignPatterns.Strategy;

Console.WriteLine("Design Patterns Demo");
Console.WriteLine("-------------------");
Console.WriteLine("Strategy Pattern");
ShowStrategy();
Console.WriteLine("-------------------");
void ShowStrategy()
{
    var paymentContext = new PaymentContext();

    // Pay using Credit Card
    paymentContext.SetPaymentStrategy(new CreditCardPayment());
    paymentContext.ExecutePayment(100.50m);

    // Switch to PayPal
    paymentContext.SetPaymentStrategy(new PayPalPayment());
    paymentContext.ExecutePayment(200.75m);

    // Switch to Bitcoin
    paymentContext.SetPaymentStrategy(new BitcoinPayment());
    paymentContext.ExecutePayment(500.00m);
}