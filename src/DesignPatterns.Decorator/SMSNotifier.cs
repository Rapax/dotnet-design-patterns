using DesignPatterns.Decorator.Abstract;

namespace DesignPatterns.Decorator;

public class SMSNotifier(INotifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending SMS: {message}");
    }
}