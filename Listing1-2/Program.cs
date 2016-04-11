using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1_2
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}",i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadMethod);
            //If IsBackground is set to true, the application finishes immediately, and will run in background
            t.IsBackground = false;
            t.Start();
        }
    }
}
