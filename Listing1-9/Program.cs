

using System;
using System.Threading.Tasks;

namespace Listing1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            Console.WriteLine(t.Result);
        }
    }
}
