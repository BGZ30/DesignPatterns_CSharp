using Pizza_Example.Pizzas;

namespace Pizza_Example
{
    public class ChicagoPizzaStore : PizzaStore{
        protected override Pizza createPizza(string type){
            Pizza pizza = null;

            switch (type){
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                case "clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}