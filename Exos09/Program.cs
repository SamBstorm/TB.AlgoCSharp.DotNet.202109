using System;

namespace Exos09
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MULTIPLICATEUR = 2;
            int nombre = 1;

            while (nombre <= 10)
            {
                 System.Console.WriteLine(nombre + " x " + MULTIPLICATEUR + " = " + (nombre * MULTIPLICATEUR));
                 nombre = nombre + 1;
                 //nombre += 1;
                 //nombre++;
            }
        }
    }
}
