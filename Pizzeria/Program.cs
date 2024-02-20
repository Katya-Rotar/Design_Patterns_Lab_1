using Pizzeria;
using Pizzeria.Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.Interface;

internal class Program
{
    public static void Main(string[] args)
    {
        // Використання Singleton Pattern для печі
        Oven oven = Oven.getInstance();
        // Використання Factory Pattern для створення інгредієнтів
        PizzaIngredientFactory pizzaIngredient = new PizzaIngredientFactory();
        Console.WriteLine("_____________________Pizza Ingredient Factory_____________________");

        IPizzaIngredientFactory pepperoni = pizzaIngredient.getPizzaFactory("Pepperoni");
        Console.WriteLine($"Pepperoni Pizza:\n {pepperoni.PrintPizzaIngredient()}");

        IPizzaIngredientFactory classic = pizzaIngredient.getPizzaFactory("Classic");
        Console.WriteLine($"Classic Pizza:\n {classic.PrintPizzaIngredient()}");
        
        PizzaFactory pizzaFactory = new PizzaFactory();

        Console.WriteLine("_____________________Pizza Factory_____________________");
        // Замовлення пепероні піци
        Pizza pepperoniPizza = pizzaFactory.CreatePizza("Pepperoni");
        if (pepperoniPizza != null)
        {
            Console.WriteLine(pepperoniPizza.PrintPizza());
        }

        // Замовлення класичної піци
        Pizza classicPizza = pizzaFactory.CreatePizza("Classic");
        if (classicPizza != null)
        {
            Console.WriteLine(classicPizza.PrintPizza());
        }
    }
}