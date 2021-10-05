using System;

namespace DemoTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Veuillez introduire un nombre entier : ");
            //string input = Console.ReadLine();
            //int nb;
            //if (int.TryParse(input, out nb))
            //{
            //    Console.WriteLine($"{input} est bien une valeur compatible INT");
            //}
            //else { 
            //    Console.WriteLine($"{input} n'est pas une valeur compatible INT");
            //}
            //Console.WriteLine($"nb vaut {nb}");

            int nb;
            do Console.WriteLine("Veuillez introduire un nombre entier : ");
            while (!int.TryParse(Console.ReadLine(), out nb));
            Console.WriteLine($"nb vaut {nb}");
        }
    }
}
