using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Review
{
    class Program
    {
        static string password;

        static void Main(string[] args)
        {
            getPassword();
            checkPassword();
        }

        public static void getPassword()
        {
            Console.WriteLine("enter your password");
            password = Console.ReadLine();
        }

        public static void checkPassword()
        {
            if (password == null)
            {
                Console.WriteLine("Password cannot be null.");
                return;
            }

            bool noSpecial = true;
            bool noCapital = true;

            if (Regex.IsMatch(password, @"[!@£#¢$&*()<>+=?/|\{},.~]"))
            {
                noSpecial = false;
            }

            if (password.Any(char.IsUpper))
            {
                noCapital = false;
            }

            bool answer = noSpecial && noCapital;

            if (!answer)
            {
                Console.WriteLine("Your password must not contain any upper casing or special characters.");
            }
            else
            {
                Console.WriteLine("Thank you for providing a valid password.");
            }
        }
    }
}
