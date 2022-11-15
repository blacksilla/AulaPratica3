using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA3
{
    internal class Ex6
    {
        static void Main(string[] args)
        {
            string MarcaA, MarcaB, MarcaC;

            Console.WriteLine("Informe a quantidade de chuteiras da Marca A: ");
            MarcaA = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de chuteiras da Marca B: ");
            MarcaB = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de chuteiras da Marca C: ");
            MarcaC =Console.ReadLine();

            Console.WriteLine("                Quantidade de chuteiras em stock:                   ");
            Console.WriteLine("      Marca (A)             Marca (B)             Marca (C)         ");
            Console.WriteLine("          "+MarcaA + "                    "+ MarcaB + "                    " + MarcaC      );
        }
    }
}
