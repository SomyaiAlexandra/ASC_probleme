using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cornertiti un numar din baza 10 intr-o baza tinta
            string line;

            Console.WriteLine("Introduceti numarul pe care doriti sa-l convertiti");
            line = Console.ReadLine();
            int numar = int.Parse(line);

            Console.WriteLine("Introduceti baza tinta, nr. intre 2-16");
            line = Console.ReadLine();
            int bazaTinta = int.Parse(line);

            int cat, rest;
            string result = "";
            Stack<int> stiva = new Stack<int>();

            while (numar > 0)
            {
                cat = numar / bazaTinta;
                rest = numar % bazaTinta;
                stiva.Push(rest);
                numar = numar / bazaTinta;

            }

            while (stiva.Count > 0)
            {
                result = result + stiva.Pop();

            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
