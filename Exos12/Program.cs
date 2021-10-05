using System;

namespace Exos12
{
    class Program
    {
        static void Main(string[] args)
        {
            int devine, proposition;
            Console.WriteLine("Joueur 1 : Veuillez choisir un nombre (entre 1 et 10) :");
            devine = int.Parse(Console.ReadLine());

            Console.WriteLine("Joueur 2 : Veuillez deviner un nombre (entre 1 et 10) :");
            proposition = int.Parse(Console.ReadLine());
            while (devine != proposition)
            {
                if (devine < proposition)
                {
                    Console.WriteLine("C'est moins!");
                }
                else
                {
                    Console.WriteLine("C'est plus!");
                }
                Console.WriteLine("Joueur 2 : Veuillez deviner un nombre (entre 1 et 10) :");
                proposition = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("C'est gagné! C'est gagné! We did it! Yeah!");
        }
    }
}
