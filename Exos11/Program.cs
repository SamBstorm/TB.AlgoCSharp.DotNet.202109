using System;

namespace Exos11
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicateur = 1;
            while (multiplicateur <= 9)
            {
                int nombre = 1;
                while (nombre <= 10)
                {
                    Console.WriteLine(nombre + " x " + multiplicateur + " = " + (nombre * multiplicateur));
                    nombre++;
                }
                multiplicateur++;
            }
        }
    }
}
