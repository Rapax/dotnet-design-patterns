using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod;

public class Moto : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a moto...");
    }
}