using System;
using Pizzas;

namespace Pizza_Example
{
    public abstract class PizzaStore{

        protected abstract Pizza createPizza(string type);

        public Pizza orderPizza(string type){

            Pizza pizza = createPizza(type);
            Console.WriteLine($"--- Start making {pizza.Name} ---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
