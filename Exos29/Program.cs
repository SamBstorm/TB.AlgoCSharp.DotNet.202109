using System;

namespace Exos29
{
    class Program
    {
        #region Version avec un seul Return
        //public static int RechercheTableau(int[] tab, int taille, int valRecherche)
        //{
        //    int index = 0, indexTrouve = -1;
        //    while (index < taille && indexTrouve == -1)
        //    {
        //        if (tab[index] == valRecherche)
        //        {
        //            indexTrouve = index;
        //        }
        //        index++;
        //    }
        //    return indexTrouve;
        //} 
        #endregion

        #region Version avec plusieurs Return
        public static int RechercheTableau(int[] tab, int taille, int valRecherche)
        {
            int index = 0;
            for(index = 0; index < taille; index++)
            {
                if (tab[index] == valRecherche)
                {
                    return index;
                }
            }
            return -1;
        }
        #endregion
        static void Main(string[] args)
        {
            const int TAILLE = 7;
            int[] tab = new int[TAILLE];
            int index, valeur;

            Random RNG = new Random();

            for (index = 0; index < TAILLE; index++)
            {
                tab[index] = RNG.Next(0, 10);
            }

            Console.WriteLine("Veuillez indiquer la valeur recherchée :");
            valeur = int.Parse(Console.ReadLine());

            index = RechercheTableau(tab, TAILLE, valeur);

            if (index == -1)
            {
                Console.WriteLine($"Pas de {valeur} dans le tableau aléatoire...");
            }
            else
            {
                Console.WriteLine($"La valeur {valeur} est en {index + 1} position du tableau.");
            }
        }
    }
}
