using Pizza_Example.Pizzas;

namespace Pizza_Example
{
    public class SimplePizzaFactory{

        public Pizza createPizza(string type){
            Pizza pizza = null;

            switch (type){
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                case "Pepperoni Pizza":
                    pizza = new PepperoniPizza();
                    break;
            }

            return pizza;
        }
    }

}