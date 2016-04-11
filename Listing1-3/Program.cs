using System;
using System.Threading;

namespace Listing1_3
{
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc {0}",i);

                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            //Construtor unecessary. 
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            //Pass 5 to object parameter in ThreadMethod, you can cast it to use in your method.
            t.Start(5);
            t.Join();
        }
    }
}
