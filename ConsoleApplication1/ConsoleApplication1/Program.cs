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
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Последовательность: {");
            foreach(int i in inp) Console.Write(i + ", ");
            Console.WriteLine("}");
            Console.ForegroundColor = tmp;
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
