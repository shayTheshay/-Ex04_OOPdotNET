using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItem;


        public MainMenu()
        {
            r_MenuItem = new MenuItem();
        }


        public MainMenu(string i_Title)
        {
            r_MenuItem = new MenuItem(i_Title);
        }


        public void AddMenuItem(MenuItem i_Item)
        {
            r_MenuItem.AddMenuItem(i_Item);
        }


        public void Show()
        {
            r_MenuItem.MainMenuShow();
        }
    }
}

