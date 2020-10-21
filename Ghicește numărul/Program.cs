using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghicește_numărul
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se scrie un program în care calculatorul generează un numar orareceare, iar persoana din fața
            //calculatorului trebuie să gjiceasca numarul.

            Random x = new Random();

            int s = x.Next(100);
            int a;
            Console.WriteLine("Introduceti un numar intreg intre 0-100");
            do
            {
                
                a = int.Parse(Console.ReadLine());
                if (a < s)
                    Console.WriteLine("Incearca mai mare");
                else if (a == s)
                {
                    Console.WriteLine("Ai ghicit");
                }
                else 
                        Console.WriteLine("Incearca mai mic");
            }
            while (a != s);
            Console.ReadKey();


        }
    }
}
