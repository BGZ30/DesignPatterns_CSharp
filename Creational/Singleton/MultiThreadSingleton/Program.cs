using System;
using System.Threading;

namespace MultiThreadSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            
            Console.WriteLine("Result\n");
            
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO", "Thread_1");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR", "Thread_2");
            });

            Thread process3 = new Thread(() =>
            {
                TestSingleton("NAT", "Thread_3");
            });
            
            process1.Start();
            process2.Start();
            process3.Start();
            
            process1.Join();
            process2.Join();
            process3.Join();
        }
        
        public static void TestSingleton(string value, string thread)
        {
            MultiThread singleton = MultiThread.getInstance(value, thread);
        } 

    }
    
}
