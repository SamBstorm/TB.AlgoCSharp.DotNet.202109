using System;

namespace Exos01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1, nb2, temp;

            Console.WriteLine("Veuillez indiquer le nombre a :");
            nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez indiquer le nombre b :");
            nb2 = int.Parse(Console.ReadLine());
            temp = nb1;
            nb1 = nb2;
            nb2 = temp;
            Console.Write("La valeur de a est ");
            Console.WriteLine(nb1);
            //Console.WriteLine("La valeur de b est {0}", nb2);
            Console.WriteLine($"La valeur de b est {nb2}");
        }
    }
}
