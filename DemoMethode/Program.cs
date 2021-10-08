using System;

namespace DemoMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int addResult = Addition(int.Parse(Console.ReadLine()), 4);
            //DemanderEtDireBonjour();
            //DireBonjour(Console.ReadLine(), "EN");

            int i = 0;
            int j = i;
            ChangeValeur(ref i, 5);
            Console.WriteLine(i);

            i = ChangeValeurOk(j);
            Console.WriteLine(i);
        }

        

        public static void ChangeValeur(ref int variable , int nouvelleValeur)
        {
            variable = nouvelleValeur;
            Console.WriteLine(variable);
        }

        public static int ChangeValeurOk(int nouvelleValeur)
        {
            return nouvelleValeur;
        }
    }
}
