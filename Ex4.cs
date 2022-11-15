using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA3
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            int i=0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- =" + (i--));
            Console.WriteLine("--i ="+(--i));
            Console.WriteLine("i += 3" + (i += 3));
            Console.WriteLine("i -= 2" + (i  -= 2));
            Console.WriteLine("i *= 2" + (i *  2));
           
            Console.WriteLine("i /=2" + (i / 2));
            Console.WriteLine("i %= 2" + (i %= 2));

        }
    }
}
