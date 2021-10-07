using System;

namespace Exos20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 4;
            int[] tab = new int[TAILLE];
            int temp, index;

            for (index = 0; index < TAILLE ; index++)
            {
                Console.WriteLine("Veuillez introduire un nombre : ");
                tab[index] = int.Parse(Console.ReadLine());
            }

            for (index = 0; index < TAILLE / 2; index++)
            {
                temp = tab[index];
                tab[index] = tab[(TAILLE - 1) - index];
                tab[(TAILLE - 1) - index] = temp;
            }

            for (index = 0; index < TAILLE; index++)
            {
                Console.WriteLine(tab[index]);
            }

            #region Exemple FOREACH (POUR CHAQUE objet DU tableau)
            //foreach (int number in tab)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion
        }
    }
}
