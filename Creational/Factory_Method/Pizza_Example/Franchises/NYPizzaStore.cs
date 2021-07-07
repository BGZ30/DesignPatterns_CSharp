using Pizza_Example.Pizzas;

namespace Pizza_Example
{
    public class NYPizzaStore : PizzaStore{
        protected override Pizza createPizza(string type){
            Pizza pizza = null;

            switch (type){
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}