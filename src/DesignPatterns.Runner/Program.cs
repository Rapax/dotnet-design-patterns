// See https://aka.ms/new-console-template for more information

using System.Text;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod.Abstract;
using DesignPatterns.FactoryMethod.Factories;
using DesignPatterns.Strategy;

Console.WriteLine("Design Patterns Demo");
Console.WriteLine("-------------------");
Console.WriteLine("Strategy Pattern");
ShowStrategy();
Console.WriteLine("-------------------");
Console.WriteLine("Builder Pattern");
ShowBuilder();
Console.WriteLine("-------------------");
Console.WriteLine("Factory Method Pattern");
ShowFactoryMethod();
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

void ShowFactoryMethod()
{
    VehicleFactory factory;

    // Create a Car
    factory = new CarFactory();
    IVehicle car = factory.CreateVehicle();
    car.Drive(); // Output: Driving a car...

    // Create a Bike
    factory = new BikeFactory();
    IVehicle bike = factory.CreateVehicle();
    bike.Drive(); // Output: Riding a bike...
    
    // Create a Bike
    factory = new MotoFactory();
    IVehicle moto = factory.CreateVehicle();
    moto.Drive(); // Output: Riding a moto...
}