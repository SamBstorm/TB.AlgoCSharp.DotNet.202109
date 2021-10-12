using System;

namespace Eval_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0, fibo1 = 0, fibo2 = 1, nombre;

            Console.WriteLine("Veuillez indiquer le nombre à vérifier : ");
            nombre = int.Parse(Console.ReadLine());

            //do Console.WriteLine("Veuillez indiquer le nombre à vérifier : ");
            //while (!int.TryParse(Console.ReadLine(), out nombre));

            while (nombre > fibo1)
            {
                Console.WriteLine(fibo1);
                fibo2 += fibo1;
                fibo1 = fibo2 - fibo1;
                index++;
            }

            if (nombre == fibo1) Console.WriteLine($"{nombre} est bien un nombre de la suite de Fibonacci : F{index}");
            else Console.WriteLine($"{nombre} n'est pas un nombre de la suite de Fibonacci");

        }
    }
}
