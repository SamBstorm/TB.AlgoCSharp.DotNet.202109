using System;

namespace Exos08
{
    class Program
    {
        static void Main(string[] args)
        {
            double nombre1, nombre2;
            char operateur;
            string resultat;

            Console.WriteLine("Premier nombre : ");
            nombre1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Opérateur : ");
            operateur = Char.Parse(Console.ReadLine());
            //operateur = Convert.ToChar(Console.ReadLine());
            //operateur = Console.ReadLine()[0];
            if ((operateur == '+') || (operateur == '-') || (operateur == '*') || (operateur == '/'))
            {
                Console.WriteLine("Second nombre :");
                nombre2 = double.Parse(Console.ReadLine());
                resultat = $"{nombre1} {operateur} {nombre2} = ";
                switch (operateur)
                {
                    case '+':
                        resultat = resultat + $"{nombre1 + nombre2}";
                        //resultat += $"{nombre1 + nombre2}";
                        break;
                    case '-':
                        resultat = resultat + $"{nombre1 - nombre2}";
                        //resultat += $"{nombre1 - nombre2}";
                        break;
                    case '*':
                        resultat = resultat + $"{nombre1 * nombre2}";
                        //resultat += $"{nombre1 * nombre2}";
                        break;
                    case '/':
                        if (nombre2 == 0) resultat = "Division tend vers l'infini et au delà!";
                        else resultat = resultat + (nombre1 / nombre2);
                        break;
                }
            }
            else resultat = "Opération invalide";
            Console.WriteLine(resultat);
        }
    }
}
