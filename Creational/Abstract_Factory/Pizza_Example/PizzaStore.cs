namespace Pizza_Example
{
    public abstract class PizzaStore{

        public Pizza OrderPizza(string type){
            var pizza = CreatePizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}