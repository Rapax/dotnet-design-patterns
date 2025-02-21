using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Controls;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Checkbox");
    }
}