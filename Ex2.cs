using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA3
{
    class Ex2
    {
        static void Main(string[] args)
        {
            int r = (150 - 20) / 2 + 5;
            // Expression for calculating the surface of the circle
            double surface = Math.PI * r * r;
            // Expression for calculating the perimeter of the circle
            double perimeter = 2*Math.PI*r;


            Console.WriteLine(r);
            Console.WriteLine(surface);
            Console.WriteLine(perimeter);


        }
    }
}
