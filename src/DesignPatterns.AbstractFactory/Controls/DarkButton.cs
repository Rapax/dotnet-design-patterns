using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Controls;

public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Button");
    }
}