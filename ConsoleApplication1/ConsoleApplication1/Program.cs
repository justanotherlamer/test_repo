using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            if(inp <= 0) yield break;

            if (inp >= 1)
            {
                yield return 1;
                if (inp >= 2)
                {
                    yield return 1;
                    int a = 1;
                    int b = 1;
                    for (int i = 3; i <= inp; i++)
                    {
                        int cur = a + b;
                        a = b;
                        b = cur;
                        yield return cur;

                    }
                }
            }
        }
    }
}
