using System;

namespace DemoRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();

            Console.WriteLine(RNG.Next(1,6));
        }
    }
}
