using System;

namespace Exos02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = 8 % 3;
            b = 4 + a;
            c = b * a;
            d = (c - a) * b;
            e = ((a + 7) * (b / a)) * 0;    //DIV est une division entière, mais a et b étant des entier, aucun soucis!

            Console.WriteLine($"La valeur de a est {a}.");
            Console.WriteLine($"La valeur de b est {b}.");
            Console.WriteLine($"La valeur de c est {c}.");
            Console.WriteLine($"La valeur de d est {d}.");
            Console.WriteLine($"La valeur de e est {e}.");
        }
    }
}
