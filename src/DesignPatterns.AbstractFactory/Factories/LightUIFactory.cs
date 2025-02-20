using DesignPatterns.AbstractFactory.Abstract;
using DesignPatterns.AbstractFactory.Controls;

namespace DesignPatterns.AbstractFactory.Factories;

public class LightUIFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new LightCheckbox();
    }
}