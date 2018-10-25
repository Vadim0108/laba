using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int pi;
            pi = a + b;
            Console.WriteLine(pi);

        }
        // Виета
        // x^2+px+q=0
        // x1+x2=-p
        // x1*x2=q
    }
}
