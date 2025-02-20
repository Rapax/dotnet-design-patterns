using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Controls;

public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Button");
    }
}