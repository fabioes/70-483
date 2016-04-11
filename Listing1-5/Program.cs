using System;
using System.Threading;

namespace Listing1_5
{
    class Program
    {
        //ThreadStatic is to each thread acess the same variable(_field) but put values in different memory path.
        //Else both thread would access, but the maximum value becomes 20, because it'll acess the same memory path.
        [ThreadStatic]
        public static int _field;
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}",_field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
