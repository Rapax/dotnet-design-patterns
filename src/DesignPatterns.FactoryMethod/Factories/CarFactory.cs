using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Factories;

public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}