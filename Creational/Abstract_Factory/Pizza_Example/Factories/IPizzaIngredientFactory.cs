namespace Pizza_Example
{
    public interface IPizzaIngredientFactory{
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IVeggies[] createVeices();
        IPepperoni createPepperoni();
        IClams createClams();
    }
}