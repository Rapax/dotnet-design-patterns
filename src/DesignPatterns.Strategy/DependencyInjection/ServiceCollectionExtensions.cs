using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Strategy.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void ConfigureStrategy(this IServiceCollection services)
    {
        services.AddKeyedTransient<IPaymentStrategy, CreditCardPayment>("credit-card");
        services.AddKeyedTransient<IPaymentStrategy, PayPalPayment>("paypal");
        services.AddKeyedTransient<IPaymentStrategy, BitcoinPayment>("bitcoin");
    }
}