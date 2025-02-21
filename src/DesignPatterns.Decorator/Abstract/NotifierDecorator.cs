namespace DesignPatterns.Decorator.Abstract;

public abstract class NotifierDecorator(INotifier notifier) : INotifier
{
    protected INotifier _notifier = notifier;

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}