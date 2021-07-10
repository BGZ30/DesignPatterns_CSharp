using System;
using System.Collections.Generic;

namespace NaiveBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.builder = builder;
            
            Console.WriteLine("Standard basic product:");
            director.buildRowProduct();
            Console.WriteLine(builder.getProduct().listParts());

            Console.WriteLine("Standard full featured product:");
            director.buildFullProduct();
            Console.WriteLine(builder.getProduct().listParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.buildPartA();
            builder.buildPartC();
            Console.Write(builder.getProduct().listParts());
        }
    }
}
