using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces = Ex04.Menus.Interfaces;
using Delegates = Ex04.Menus.Delegates;



namespace Ex04.Menus.Test
{

    public class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu myMenuInterfaces = MenuBuilder.BuildMainMenuInterfaces();
            myMenuInterfaces.Show();
            Delegates.MainMenu myMenuDelegates = MenuBuilder.BuildMainMenuDelegates();
            myMenuDelegates.Show();
        }

    }
}
