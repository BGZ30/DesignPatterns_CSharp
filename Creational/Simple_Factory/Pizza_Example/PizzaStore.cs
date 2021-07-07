using System;
using Pizza_Example.Pizzas;

namespace Pizza_Example{

    public class PizzaStore{
        SimplePizzaFactory factory;

        // Constructor
        public PizzaStore(SimplePizzaFactory Factory){
            factory = Factory;
        }

        public Pizza orderPizza(string type){
            Pizza pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            
            Console.WriteLine(pizza.ToString());

            return pizza;
        }

    }

}