// See https://aka.ms/new-console-template for more information

using System.Text;
using DesignPatterns.Builder;
using DesignPatterns.Strategy;

Console.WriteLine("Design Patterns Demo");
Console.WriteLine("-------------------");
Console.WriteLine("Strategy Pattern");
ShowStrategy();
Console.WriteLine("-------------------");
Console.WriteLine("-------------------");
Console.WriteLine("Builder Pattern");
ShowBuilder();
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

void ShowBuilder()
{
    var mailMessage = new MailMessageBuilder()
        .Subject("Design Patterns Demo")
        .To("john.doe@test.com")
        .From("jane.doe@test.com")
        .Body("This is a test email.", Encoding.UTF8)
        .Build();

    var message = mailMessage.Print();
    Console.WriteLine(message);
}