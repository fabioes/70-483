
using System;
using System.Threading.Tasks;

namespace LIsting1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*");
                }
            });
            t.Wait();
        }

    }
}
