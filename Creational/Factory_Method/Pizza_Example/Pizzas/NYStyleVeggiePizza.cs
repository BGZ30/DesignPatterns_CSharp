﻿using System;
using Pizza_Example.Pizzas;

namespace Pizza_Example
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Garlic");
            Toppings.Add("Onion");
            Toppings.Add("Mushrooms");
            Toppings.Add("Red Pepper");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}