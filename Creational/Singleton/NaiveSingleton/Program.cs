using System;

namespace NaiveSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client code
            Console.WriteLine("Create an instance for the first time....");
            Singleton instance_1 = Singleton.getInstance();
            
            Console.WriteLine("\n");
            
            Console.WriteLine("Try to create a new instance?");
            Singleton instance_2 = Singleton.getInstance();
        }
    }
}
