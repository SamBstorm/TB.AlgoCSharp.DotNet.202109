using System;

namespace Exos21
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 7;
            int[] tab = new int[TAILLE];
            int index, temp;
            bool echange;

            Random RNG = new Random(); //Générateur de valeur aléatoire

            for (index = 0; index < TAILLE; index++)
            {
                tab[index] = RNG.Next(0, 10);
            }

            Console.WriteLine("Voici notre tableau non-trié :");
            for (index = 0; index < TAILLE; index++)
            {
                Console.WriteLine(tab[index]);
            }

            do
            {
                echange = false;
                for (index = 0; index < TAILLE-1 ; index++)
                {
                    if (tab[index] > tab[index+1])
                    {
                        temp = tab[index];
                        tab[index] = tab[index + 1];
                        tab[index + 1] = temp;
                        echange = true;
                    }
                }
            } while (echange);

            Console.WriteLine("Voici notre tableau trié :");
            for (index = 0; index < TAILLE; index++)
            {
                Console.WriteLine(tab[index]);
            }
        }
    }
}
