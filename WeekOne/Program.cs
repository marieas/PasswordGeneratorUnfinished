using System;
using System.Collections.Generic;

namespace WeekOne
{
    class Program
    {
        /*Samle nå all validering i en egen metode IsValid()
         * som returnerer true hvis alt er i orden og false ellers.
         * Lag også en egen metode ShowHelpText()
         *som viser den nevnte teksten. 
         *Begynnelsen på Main() skal nå være slik:
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }
        */
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                PrintMenu();
            }
            if(args.Length == 2)
            {
                var argumentOne = args[0];
                foreach(var character in argumentOne)
                {
                   var isDigit = char.IsDigit(character);
                    if(isDigit == false)
                    {
                        PrintMenu();
                        return;
                    }
                }
                var argumentTwo = args[1];
                foreach(var chaar in argumentTwo)
                {
                    if(chaar == 'l' || chaar == 'L' || chaar == 'd' || chaar == 's')
                    {
                        //ok
                    }
                    else
                    {
                        PrintMenu();
                    }
                }
            }
            else
            {
                PrintMenu();
            }
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length == 0)
            {
                return false;
            }
            if (args.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void PrintMenu()
        {
            string optionsText = @" PasswordGenerator
            Options:
              - l = lower case letter
              - L = upper case letter
              - d = digit
            - s = special character (!""#¤%&/(){}[]
            Example: PasswordGenerator 14 lLssdd
             Min. 1 lower case

             Min. 1 upper case

             Min. 2 special characters

             Min. 2 digits";
            Console.WriteLine(optionsText);
        }
    }

}
