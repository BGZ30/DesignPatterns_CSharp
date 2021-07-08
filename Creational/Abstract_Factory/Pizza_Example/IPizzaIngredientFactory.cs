namespace Pizza_Example
{

    public interface IPizzaIngredientFactory{
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IClams createClams();

    }
}