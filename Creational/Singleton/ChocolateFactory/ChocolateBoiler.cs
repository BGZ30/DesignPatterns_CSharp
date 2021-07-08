using System;

namespace ChocolateFactory
{
    public class ChocolateBoiler{

        private static ChocolateBoiler uniqueBoiler;

        public static ChocolateBoiler instance{

            get{
                if(uniqueBoiler == null){
                    Console.WriteLine("Creating a unique instance of ChocolateBoiler");
                    uniqueBoiler = new ChocolateBoiler();

                    Console.WriteLine("The unique instance has been created");
                }

                else
                    Console.WriteLine("There is already a unique instance, cannot create a new one.");
                
                return uniqueBoiler;
            }
        }

        public bool empty { get; private set; }
        public bool boiled { get; private set; }

        // Constructor
        private ChocolateBoiler(){
            empty = true;
            boiled = false;
        }

        // other methods
        public void fill(){
            if (empty){
                empty = false;
                boiled = false;

                Console.WriteLine("The boiler has been filled.");
            }
        }

        public void boil(){
            if (!empty && !boiled){
                boiled = true;

                Console.WriteLine("The milk has been boiled.");
            }
        }

        public void drain(){
            if (!empty && boiled){
                empty = true;

                Console.WriteLine("Drain the chocolate and milk");
            }
        }

    }
}