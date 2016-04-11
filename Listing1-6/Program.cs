using System;
using System.Threading;

namespace Listing1_6
{
    class Program
    {
        //ThreadLocal<> is a way to assign a value to a variable that all threads can access without ThreadStatic decoration
        //Again same variable, different memory path
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                //Thread.CurrentThread is execution context
                //if you don't need this data, disable it by using, ExecutionContext.SurpressFlow method
                return Thread.CurrentThread.ManagedThreadId;
            });
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
