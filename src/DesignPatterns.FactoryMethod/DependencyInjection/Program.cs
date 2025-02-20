using DesignPatterns.FactoryMethod.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.FactoryMethod.DependencyInjection;

public class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<IVehicle, Car>()
            .AddTransient<IVehicle, Bike>()
            .AddTransient<IVehicle, Moto>()
            .AddSingleton<IVehicleFactory, VehicleFactory>()
            .BuildServiceProvider();
        
        var vehicleFactory = serviceProvider.GetRequiredService<IVehicleFactory>();

        var car = vehicleFactory.CreateVehicle("car");
        car.Drive();  // Output: Driving a car...

        var bike = vehicleFactory.CreateVehicle("bike");
        bike.Drive();  // Output: Riding a bike...
        
        var moto = vehicleFactory.CreateVehicle("moto");
        moto.Drive();  // Output: Riding a bike...
    }
}