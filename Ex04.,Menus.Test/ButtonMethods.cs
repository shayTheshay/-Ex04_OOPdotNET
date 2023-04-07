using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ButtonMethods
    {
        internal static void ShowVersion()
        {
            Console.WriteLine("Version: 23.1.4.8859");
        }

        internal static void CountUppercase()
        {
            Console.WriteLine("Please input a sentance:");
            string input = Console.ReadLine();
            int amountOfUpper = 0;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    amountOfUpper++;
                }
            }
            Console.WriteLine("Your sentance: {0} had {1} uppercase letters", input, amountOfUpper);
        }
        internal static void ShowDate()
        {
            Console.WriteLine("The date today is {0}", DateTime.Now.ToShortDateString());
        }

        internal static void ShowTime()
        {
            Console.WriteLine("The date today is {0}", DateTime.Now.TimeOfDay);
        }
    }
}
