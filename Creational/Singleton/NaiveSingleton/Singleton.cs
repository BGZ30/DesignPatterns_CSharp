/*
    just need to hide the constructor and implement a static creation method.
*/
using System;

namespace NaiveSingleton
{
    class Singleton{

        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton() { }

        // The Singleton's instance is stored in a static field.
        public static Singleton instance;

        public static Singleton getInstance(){
            if (instance == null){
                instance = new Singleton();

                Console.WriteLine("A new instance has been created.");
            }

            else 
                Console.WriteLine("There is already an instance.");
            
            return instance;
        }
    }
}