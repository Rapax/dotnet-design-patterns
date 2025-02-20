namespace DesignPatterns.Strategy;

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy = null!;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            throw new InvalidOperationException("Payment strategy is not set.");
        }
        
        _paymentStrategy.Pay(amount);
    }
}