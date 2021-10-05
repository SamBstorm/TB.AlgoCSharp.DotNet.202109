using System;

namespace Exos15
{
    class Program
    {
        static void Main(string[] args)
        {
            const int EXPOSANT = 10;
            double nombre, resultat;
            int compteur = 1;
            Console.WriteLine("Veuillez introduire un nombre : ");
            nombre = double.Parse(Console.ReadLine());
            resultat = nombre;
            do
            {
                resultat = resultat * nombre;  // resultat *= nombre;
                compteur++;
            } while (compteur < EXPOSANT);
            Console.WriteLine($"{nombre} exposant {EXPOSANT} donne {resultat}");
        }
    }
}
