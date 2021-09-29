using System;

namespace Exos03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version 1

            int sec, min, heure, jour;
            Console.WriteLine("Combien de secondes?");
            sec = int.Parse(Console.ReadLine());
            jour = sec / 86_400;
            sec = sec % 86_400;
            heure = sec / 3600;
            sec = sec % 3600;
            min = sec / 60;
            sec = sec % 60;

            Console.WriteLine($"Cela fait {jour} jour(s) {heure} : {min} : {sec}");

            #endregion
            #region Version 2

            #endregion

            #region Version 3

            #endregion

        }
    }
}
