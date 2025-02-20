using DesignPatterns.FactoryMethod.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.FactoryMethod.DependencyInjection;

public class VehicleFactory(IServiceProvider serviceProvider) : IVehicleFactory
{
    public IVehicle CreateVehicle(string vehicleType)
    {
        return vehicleType.ToLower() switch
        {
            "car" => serviceProvider.GetRequiredService<Car>(),
            "bike" => serviceProvider.GetRequiredService<Bike>(),
            "moto" => serviceProvider.GetRequiredService<Moto>(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}