using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("initial version");
            WriteSequence(Sequence(10));
            
            Console.ReadKey();
        }

        static void WriteSequence(IEnumerable<int> inp)
        {
            foreach(int i in inp) Console.WriteLine(i);
        }

        static IEnumerable<int> Sequence(int inp)
        {
            for (int i = 0; i < inp; i++)
            {
                yield return 1;
            } 
        }
    }
}
