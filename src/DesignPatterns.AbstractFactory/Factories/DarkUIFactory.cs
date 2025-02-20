using DesignPatterns.AbstractFactory.Abstract;
using DesignPatterns.AbstractFactory.Controls;

namespace DesignPatterns.AbstractFactory.Factories;

public class DarkUIFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new DarkButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new DarkCheckbox();
    }
}