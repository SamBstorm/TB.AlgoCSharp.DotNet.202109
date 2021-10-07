using System;

namespace Exos19
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VERSION SANS TRYPARSE
            //const int TAILLE = 10;
            //int[] tabScores = new int[TAILLE];
            //int nbJoueurs;
            //double moyenne = 0;

            //do
            //{
            //    Console.WriteLine($"Veuillez indiquer le nombre de joueurs (2 à {TAILLE} joueurs) :");
            //    nbJoueurs = int.Parse(Console.ReadLine());
            //} while (nbJoueurs < 2 || nbJoueurs > TAILLE);

            //for (int index = 0; index <= nbJoueurs - 1; index = index + 1)
            //{
            //    Console.WriteLine($"Veuillez indiquer le score du joueur {index + 1} :");
            //    tabScores[index] = int.Parse(Console.ReadLine());
            //}

            //for (int index = 0; index <= nbJoueurs - 1; index = index + 1)
            //{
            //    moyenne = moyenne + tabScores[index];
            //}

            //Console.WriteLine($"La moyenne des scores de la partie est  {moyenne / nbJoueurs}");
            #endregion
            
            
            #region VERSION AVEC TRYPARSE
            const int TAILLE = 10;
            int[] tabScores = new int[TAILLE];
            int nbJoueurs;
            double moyenne = 0;

            do
            {
                do
                {
                    Console.WriteLine($"Veuillez indiquer le nombre de joueurs (2 à {TAILLE} joueurs) :");
                } while (!int.TryParse(Console.ReadLine(), out nbJoueurs));
            } while (nbJoueurs < 2 || nbJoueurs > TAILLE);

            for (int index = 0; index <= nbJoueurs - 1; index = index + 1)
            {
                do {
                    Console.WriteLine($"Veuillez indiquer le score du joueur {index + 1} :");
                } while (!int.TryParse(Console.ReadLine(), out tabScores[index]));
            }

            for (int index = 0; index <= nbJoueurs - 1; index = index + 1)
            {
                moyenne = moyenne + tabScores[index];
            }

            Console.WriteLine($"La moyenne des scores de la partie est  {moyenne / nbJoueurs}"); 
            #endregion
        }
    }
}
