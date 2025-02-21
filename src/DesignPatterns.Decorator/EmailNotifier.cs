using DesignPatterns.Decorator.Abstract;

namespace DesignPatterns.Decorator;

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}