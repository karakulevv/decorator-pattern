# Decorator Pattern Example

## Overview
This example illustrates the Decorator Pattern, a structural design pattern that allows behavior to be added to individual objects, either statically or dynamically, without affecting the behavior of other objects from the same class.

## Interface
The `ICoffee` interface defines the basic operations that concrete coffee classes must implement: `GetDescription()` and `GetCost()`.

## Concrete Component
The `SimpleCoffee` class is a concrete component that implements the `ICoffee` interface. It represents a basic coffee with a default description and cost.

## Decorator Abstract Class
The `CoffeeDecorator` abstract class is the base class for all concrete decorators. It also implements the `ICoffee` interface, holding a reference to the decorated coffee instance. The `GetDescription()` and `GetCost()` methods are overridden to delegate the calls to the decorated coffee.

## Concrete Decorator - Milk
The `MilkDecorator` class is a concrete decorator that adds the functionality of milk to a coffee. It extends the `CoffeeDecorator` class, modifying the `GetDescription()` and `GetCost()` methods to include the additional features.

## Concrete Decorator - Sugar
The `SugarDecorator` class is another concrete decorator that adds the functionality of sugar to a coffee. Similar to the `MilkDecorator`, it extends the `CoffeeDecorator` class and adjusts the `GetDescription()` and `GetCost()` methods accordingly.

## Client Usage
The `Program` class demonstrates how to use the decorator pattern to create a sequence of decorated coffee objects. It starts with a simple coffee and progressively adds milk and sugar, printing out the description and cost at each step. This showcases the dynamic composition of functionalities in a flexible and modular manner.
