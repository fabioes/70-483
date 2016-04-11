

using System;
using System.Threading;

namespace Thread_001
{
    class Program
    {
        /// <summary>
        /// New Thread Outside MainThread.
        /// </summary>
        public static void ThreadMethod()
        {
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
            }
        }
        static void Main(string[] args)
        {
            //Calling ThreadMethod in another thread...
            //This constructor is unusual and unecessary...it can be new Thread(ThreadMethod);
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            //Initialize a for loop in main thread
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread: Do some work.");
                //Signal to Windows this thread is finished
                Thread.Sleep(0);
            }
            //Waits the ThreadMethod finish
            t.Join();
            //Only to see display
            Console.ReadLine();
        }
    }
}
