using System;

namespace Exos17
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 6;
            int[] tab = new int[TAILLE];
            int index = 0, nbElement = 0;

            while (nbElement < TAILLE)
            {
                Console.WriteLine($"Veuillez indiquer une valeur pour la case {nbElement + 1}: ");
                tab[nbElement] = int.Parse(Console.ReadLine());
                nbElement++;
            }

            while (index < nbElement)
            {
                Console.WriteLine($"La case {index + 1} vaut : {tab[index]}");
                index++;
            }
        }
    }
}
