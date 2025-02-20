using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Factories;

public class MotoFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Moto();
    }
}