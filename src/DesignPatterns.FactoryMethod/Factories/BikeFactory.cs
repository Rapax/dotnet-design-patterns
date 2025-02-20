using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Factories;

public class BikeFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Bike();
    }
}