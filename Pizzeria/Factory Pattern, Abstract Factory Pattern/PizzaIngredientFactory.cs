﻿using Pizzeria.Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern
{
    public class PizzaIngredientFactory
    {
        public IPizzaIngredientFactory getPizzaFactory(string name)
        {
            switch (name)
            {
                case "Pepperoni":
                    return new PepperoniPizzaIngredientFactory();
                case "Classic":
                    return new ClassicPizzaIngredientFactory();
                default:
                    Console.WriteLine($"Unknown pizza type: {name}");
                    return null;
            }
        }
    }
}