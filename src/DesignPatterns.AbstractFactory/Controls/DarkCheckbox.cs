using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Controls;

public class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Checkbox");
    }
}