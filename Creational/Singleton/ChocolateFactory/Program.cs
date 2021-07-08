using System;

namespace ChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.instance;
            boiler.fill();
            boiler.boil();
            boiler.drain();

            // try to create a nother boiler
            ChocolateBoiler boiler2 = ChocolateBoiler.instance;
        }
    }
}
