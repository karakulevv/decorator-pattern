using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;

/// <summary>
/// ConcreteDecorator
/// </summary>
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}