using System;

namespace Exos05
{
    class Program
    {
        static void Main(string[] args)
        {
            int annee;

            Console.WriteLine("Veuiller indiquer l'année à analyser :");
            annee = int.Parse(Console.ReadLine());
            if (((annee % 4 == 0) && !(annee % 100 == 0)) || (annee % 400 == 0))
            {
                Console.WriteLine($"{annee} est une année bissextile");
            }
            else
            {
                Console.WriteLine($"{annee} n'est pas une année bissextile");
            }

            //if (((annee % 4 == 0) && !(annee % 100 == 0)) || (annee % 400 == 0)) Console.WriteLine($"{annee} est une année bissextile");
            //else Console.WriteLine($"{annee} n'est pas une année bissextile");
        }
    }
}
