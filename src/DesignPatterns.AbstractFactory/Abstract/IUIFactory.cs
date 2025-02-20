namespace DesignPatterns.AbstractFactory.Abstract;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}