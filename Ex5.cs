using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA3
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            int squarePerimeter = 17;

            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide);
            Console.WriteLine(squareArea);

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a + (b++));
            Console.WriteLine(a + b);
            Console.WriteLine(a + (++b));
            Console.WriteLine(a + b);
            Console.WriteLine(14 / a);
            Console.WriteLine(14 % a);
            int one = 1;
            int zero = 0;
            //Console.WriteLine(one / zero); Dá erro, não se pode dividir por 0

        }
    }
}
