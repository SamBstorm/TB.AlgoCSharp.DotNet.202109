using System;

namespace Exos28
{
    class Program
    {
        public static int Carre(int nombre)
        {
            return nombre * nombre ;
        }

        static void Main(string[] args)
        {
            int nb, result;

            nb = 2;
            result = Carre(nb);

            //OU

            Console.WriteLine(Carre(2));
        }
    }
}
