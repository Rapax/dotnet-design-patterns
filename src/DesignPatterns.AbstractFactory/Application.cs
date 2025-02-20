using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory;

public class Application(IUIFactory factory)
{
    private readonly IButton _button = factory.CreateButton();
    private readonly ICheckbox _checkbox = factory.CreateCheckbox();

    public void Render()
    {
        _button.Render();
        _checkbox.Render();
    }
}