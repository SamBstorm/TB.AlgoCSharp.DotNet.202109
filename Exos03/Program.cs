using System;

namespace Exos03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version 1

            //int sec, min, heure, jour;
            //Console.WriteLine("Combien de secondes?");
            //sec = int.Parse(Console.ReadLine());
            //jour = sec / 86_400;
            //sec = sec % 86_400;
            //heure = sec / 3600;
            //sec = sec % 3600;
            //min = sec / 60;
            //sec = sec % 60;

            //Console.WriteLine($"Cela fait {jour} jour(s) {heure} : {min} : {sec}");

            #endregion

            #region Version 2

            //const int MINUTE = 60, HEURE = 3600, JOUR = 86400;
            //int sec, min, heure, jour;

            //Console.WriteLine("Combien de secondes ?");
            //sec = int.Parse(Console.ReadLine());
            //jour = sec / JOUR;
            //heure = (sec % JOUR) / HEURE;
            //min = (sec % HEURE) / MINUTE;
            //sec = sec % MINUTE;

            //Console.WriteLine($"Cela fait {jour} jour(s) {heure} : {min} : {sec}");

            #endregion

            #region Version 3

            //int sec, min, heure, jour;

            //Console.WriteLine("Combien de secondes ?");
            //sec = int.Parse(Console.ReadLine());
            //min = sec / 60;
            //sec = sec % 60;
            //heure = min / 60;
            //min = min % 60;
            //jour = heure / 24;
            //heure = heure % 24;

            //Console.WriteLine($"Cela fait {jour} jour(s) {heure} : {min} : {sec}");

            #endregion

            #region Version 4

            int temp, sec, min, heure, jour;

            Console.WriteLine("Combien de secondes ?");
            temp = int.Parse(Console.ReadLine());
            min = temp / 60;
            sec = temp % 60;
            heure = min / 60;
            min = min % 60;
            jour = heure / 24;
            heure = heure % 24;

            Console.WriteLine($"{temp} secondes fait {jour} jour(s) {heure} : {min} : {sec}");

            #endregion
        }
    }
}
