using System;
using System.Collections.Generic;

// Product class
class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; }

    public Pizza()
    {
        Toppings = new List<string>();
    }

    public void Display()
    {
        Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and toppings: ");
        foreach (var topping in Toppings)
        {
            Console.WriteLine($"- {topping}");
        }
    }
}

// Builder interface
interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildToppings();
    Pizza GetPizza();
}

// Concrete builder
class HawaiianPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;

    public HawaiianPizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public void BuildDough()
    {
        _pizza.Dough = "Regular";
    }

    public void BuildSauce()
    {
        _pizza.Sauce = "Tomato";
    }

    public void BuildToppings()
    {
        _pizza.Toppings.Add("Ham");
        _pizza.Toppings.Add("Pineapple");
        _pizza.Toppings.Add("Cheese");
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}

// Director
class PizzaDirector
{
    private readonly IPizzaBuilder _builder;

    public PizzaDirector(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructPizza()
    {
        _builder.BuildDough();
        _builder.BuildSauce();
        _builder.BuildToppings();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a pizza using the builder pattern
        IPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
        PizzaDirector pizzaDirector = new PizzaDirector(hawaiianPizzaBuilder);
        pizzaDirector.ConstructPizza();
        Pizza pizza = hawaiianPizzaBuilder.GetPizza();

        // Displaying the created pizza
        pizza.Display();

        Console.ReadLine();
    }
}