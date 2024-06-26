﻿using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Models;

// ConcreteComponent
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 1.0;
    }
}