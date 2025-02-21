using DesignPatterns.Decorator.Abstract;

namespace DesignPatterns.Decorator;

public class FacebookNotifier(INotifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Posting to Facebook: {message}");
    }
}