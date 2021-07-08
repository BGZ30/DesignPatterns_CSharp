using Ingredients;

namespace Pizza_Example
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory{
        public ICheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams createClam()
        {
            return new FrozenClams();
        }

        public IDough createDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] createVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new Eggplant() };
            return veggies;
        }
    }
}