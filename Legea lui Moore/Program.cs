

using System;
using System.Data.SqlClient;

namespace Legea_lui_Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dupa cat timp vom avea o putere de calcul de 100 de ori mai mare fata de cat avem la un moment dat, la acelasi pret?
            // Conform legii lui Moore puterea de calcul se dubleaza la fiecare 18 luni ( un an si jumatate )

            string consol;
            double cateori;
            while (true)

            {
                System.Console.WriteLine("Introduceti un numar n pentru a afla timpul necesar");
                consol = Console.ReadLine();
                if (double.TryParse(consol, out cateori))
                {
                    double ani;
                    ani = 1.5 * Math.Log(cateori, 2);
                    Console.WriteLine("Peste {1} ani, puterea de calcul va fi de {0} mai mare", cateori, ani);
                    break;
                }
                else
                {
                    Console.WriteLine("Introduceri un numar rational");
                    Console.WriteLine("");
                }

            }

        }
    }
}