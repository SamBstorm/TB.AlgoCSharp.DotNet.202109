using System;

namespace Eval_ToDoList
{
    class Program
    {
        public static void AfficherTaches(string[] tab, int taille, int tailleMax)
        {
            for (int index = 0; index < taille; index++)
            {
                Console.WriteLine($"{index + 1}. {tab[index]}");
            }
            Console.WriteLine($"{tailleMax + 1}. Quitter");
            Console.WriteLine("Quel tâche supprimer : ");
        }

        public static int SupprimerTache(int id, string[] tab, int taille)
        {
            for (int index = id-1; index < taille; index++)
            {
                if (index == taille - 1) tab[index] = "";
                else tab[index] = tab[index + 1];

                //tab[index] = (index == taille - 1)?"" : tab[index + 1];
            }
            taille--;
            return taille;
        }

        public static int EncoderTaches(string[] tab, int taille)
        {
            string input;
            int count = 0;
            do
            {
                Console.WriteLine($"Encodez votre tâche n°{count + 1} : ");
                input = Console.ReadLine();
                if (input != "FIN")
                {
                    tab[count] = input;
                    count++;
                }
            } while (input != "FIN" && count < taille);
            return count;
        }

        static void Main(string[] args)
        {
            const int TAILLE = 8;
            string[] tasks = new string[TAILLE];
            int count, taskId;

            count = EncoderTaches(tasks, TAILLE);

            do
            {
                AfficherTaches(tasks, count, TAILLE);
                taskId = int.Parse(Console.ReadLine());
                count = SupprimerTache(taskId, tasks, count);
            } while (taskId != TAILLE+1 && count > 0);
        }
    }
}
