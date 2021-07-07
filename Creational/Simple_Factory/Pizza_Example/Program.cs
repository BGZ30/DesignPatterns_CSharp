using System;
using Pizza_Example.Pizzas;

namespace Pizza_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.orderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);
        
            pizza = store.orderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = store.orderPizza("clam");
            Console.WriteLine("We ordered a " + pizza.Name);
        }
    }
}
