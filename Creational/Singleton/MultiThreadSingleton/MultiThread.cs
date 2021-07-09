/*
    * in a multithreaded environment. Multiple threads can call the creation method simultaneously and get several instances of Singleton class.
    * To fix the problem, we have to synchronize threads during the first creation of the Singleton object.
*/

using System;

namespace MultiThreadSingleton
{
    class MultiThread{

        // private constructor
        private MultiThread() { }

        // private instance
        private static MultiThread instance;

        // name of the instance
        public string Value {get; set;}
        public string Thrd {get; set;}

        // create a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        public static MultiThread getInstance(string value, string thread){
            if (instance == null){
                // if there are multiple threads, they may all pass the prevoius condition,
                // but only one instance can be created.
                // the lock object controls this, the first thread reach this part will be
                // able to create the instance, while the rest will have to wait.

                Console.WriteLine($"There is a thread that requires to create an instance, thread {thread}");

                lock (_lock){
                    if (instance == null){
                        Console.WriteLine("There is no instance yet.");
                        instance = new MultiThread();
                        instance.Value = value;
                        instance.Thrd = thread;
                        Console.WriteLine($"An instance has been created with name {instance.Value} with thred {instance.Thrd}"); 
                    }

                    else{
                        Console.WriteLine($"Thread {thread} tries to create a new instance.");
                        Console.WriteLine($"There is already an instance with name {instance.Value}");
                    }
                }
            }

            return instance;
        }

    }
}