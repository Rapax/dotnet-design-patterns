using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a bike...");
    }
}