

using System.Threading.Tasks;

namespace Listing1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;

            }).ContinueWith((i) => { return i.Result; });
        }
    }
}
