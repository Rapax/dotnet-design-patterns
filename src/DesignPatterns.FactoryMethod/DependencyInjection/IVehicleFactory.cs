using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.DependencyInjection;

public interface IVehicleFactory
{
    IVehicle CreateVehicle(string vehicleType);
}