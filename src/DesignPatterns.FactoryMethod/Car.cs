using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car...");
    }
}