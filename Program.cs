using DecoratorPattern.Decorators;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Models;

static class Program
{
    public static void Main(string[] args)
    {
        // Creating a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        // Adding milk to the coffee
        ICoffee milkCoffee = new MilkDecorator(coffee);
        Console.WriteLine($"Description: {milkCoffee.GetDescription()}, Cost: ${milkCoffee.GetCost()}");

        // Adding sugar to the coffee
        ICoffee sugarMilkCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine($"Description: {sugarMilkCoffee.GetDescription()}, Cost: ${sugarMilkCoffee.GetCost()}");
    }
}