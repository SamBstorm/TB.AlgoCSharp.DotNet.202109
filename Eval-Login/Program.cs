using System;

namespace Eval_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, password, checkEmail, checkPassword;
            int nbTentative = 3;
            Console.WriteLine("Veuillez introduire votre e-mail :");
            email = Console.ReadLine();
            Console.WriteLine("Veuillez introduire votre mot de passe :");
            password = Console.ReadLine();

            do
            {
                Console.WriteLine("Veuillez vous authentifier");
                Console.WriteLine($"{nbTentative} tentatives restantes");
                Console.Write("e-mail : ");
                checkEmail = Console.ReadLine();
                Console.Write("mot de passe : ");
                checkPassword = Console.ReadLine();
                nbTentative--;
            } while (((email != checkEmail) || (password != checkPassword)) && (nbTentative != 0));

            if (email == checkEmail && password == checkPassword)
            {
                Console.WriteLine($"Bienvenu {email}");
            }
            else
            {
                Console.WriteLine("Accès refusé");
            }
        }
    }
}
