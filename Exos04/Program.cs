using System;

namespace Exos04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 9, e = 9;
            bool c = false, d = !c;
            bool r1,
                r2,
                r3,
                r4,
                r5,
                r6,
                r7,
                r8;

            r1 = (a > 8);                                                           //false
            r2 = (b == 9);                                                          //true
            r3 = !(a != 3);                                                         //true
            r4 = !c;                                                                //true
            r5 = (a < b) || c;                                                      //true
            r6 = !((a + b) != 12);                                                  //true
            r7 = ((b == 5) || ((e > 10) && (a < 8)));                               //false
            //(faux || (faux && vrai)) => (faux || faux) => faux
            r8 = (((b == 5) || ((e > 10) && (a < 8))) || (a < b) || c) && c;        //false

            Console.WriteLine($"Réponse 1 : {r1}\nRéponse 2 : {r2}\nRéponse 3 : {r3}\nRéponse 4 : {r4}\nRéponse 5 : {r5}\nRéponse 6 : {r6}\nRéponse 7 : {r7}\nRéponse 8 : {r8}");
        }
    }
}
