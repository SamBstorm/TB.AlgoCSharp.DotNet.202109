using System;

namespace Exos22
{
    class Program
    {
        static void Main(string[] args)
        {
            const int   TAILLE1 = 4,
                        TAILLE2 = 3,
                        TAILLE3 = TAILLE1 + TAILLE2;
            int[]   tab1 = new int[TAILLE1],
                    tab2 = new int[TAILLE2],
                    tab3 = new int[TAILLE3];
            int temp;

            Random RNG = new Random();

            for (int index = 0; index < TAILLE1; index++)
            {
                tab1[index] = RNG.Next(0, 10);
            }

            for (int index = 0; index < TAILLE2; index++)
            {
                tab2[index] = RNG.Next(0, 10);
            }

            Console.WriteLine("Premier tableau : ");
            for (int index = 0; index < TAILLE1; index++)
            {
                Console.WriteLine( tab1[index] );
            }

            Console.WriteLine("Second tableau : ");
            for (int index = 0; index < TAILLE2; index++)
            {
                Console.WriteLine(tab2[index]);
            }

            for (int index = 0; index < TAILLE3; index++)
            {
                if (index < TAILLE1) tab3[index] = tab1[index];
                else tab3[index] = tab2[index - TAILLE1];
                if (index > 0)
                {
                    int index2 = index;
                    while ((index2 > 0) && (tab3[index2] < tab3[index2 - 1]))
                    {
                        temp = tab3[index2];
                        tab3[index2] = tab3[index2 - 1];
                        tab3[index2 - 1] = temp;
                        index2--;
                    }
                }
            }

            Console.WriteLine("Tableaux fusionnés : ");
            for (int index = 0; index < TAILLE3; index++)
            {
                Console.WriteLine(tab3[index]);
            }
        }
    }
}
