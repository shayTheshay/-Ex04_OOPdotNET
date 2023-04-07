using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class MenuBuilder
    {
        public static Interfaces.MainMenu BuildMainMenuInterfaces()
        {
            Interfaces.MainMenu myMenu = new Interfaces.MainMenu("Interface Main Menu");
            Interfaces.MenuItem VersionAndUppercase = new Interfaces.MenuItem("Version and Uppercase");
            Interfaces.MenuItem DateTime = new Interfaces.MenuItem("Show Date/Time");
            Interfaces.MenuItem ShowVersion = new Interfaces.MenuItem("Show Version", new ShowVersionButton());
            Interfaces.MenuItem CountUppercase = new Interfaces.MenuItem("Count Uppercase", new CountUppercaseButton());
            VersionAndUppercase.AddMenuItem(ShowVersion);
            VersionAndUppercase.AddMenuItem(CountUppercase);
            Interfaces.MenuItem ShowDate = new Interfaces.MenuItem("Show Date", new ShowDateButton());
            Interfaces.MenuItem ShowTime = new Interfaces.MenuItem("Show Time", new ShowTimeButton());
            DateTime.AddMenuItem(ShowDate);
            DateTime.AddMenuItem(ShowTime);
            myMenu.AddMenuItem(VersionAndUppercase);
            myMenu.AddMenuItem(DateTime);
            return myMenu;
        }

        public static Delegates.MainMenu BuildMainMenuDelegates()
        {
            Delegates.MainMenu myMenu = new Delegates.MainMenu("Delegates Main Menu");
            Delegates.MenuItem VersionAndUppercase = new Delegates.MenuItem("Version and Uppercase");
            Delegates.MenuItem DateTime = new Delegates.MenuItem("Show Date/Time");
            Delegates.MenuItem ShowVersion = new Delegates.MenuItem("Show Version");
            ShowVersion.AddButtonFunctionality(ButtonMethods.ShowVersion);
            Delegates.MenuItem CountUppercase = new Delegates.MenuItem("Count Uppercase");
            CountUppercase.AddButtonFunctionality(ButtonMethods.CountUppercase);
            VersionAndUppercase.AddMenuItem(ShowVersion);
            VersionAndUppercase.AddMenuItem(CountUppercase);
            Delegates.MenuItem ShowDate = new Delegates.MenuItem("Show Date");
            ShowDate.AddButtonFunctionality(ButtonMethods.ShowDate);
            Delegates.MenuItem ShowTime = new Delegates.MenuItem("Show Time");
            ShowTime.AddButtonFunctionality(ButtonMethods.ShowTime);
            DateTime.AddMenuItem(ShowDate);
            DateTime.AddMenuItem(ShowTime);
            myMenu.AddMenuItem(VersionAndUppercase);
            myMenu.AddMenuItem(DateTime);
            return myMenu;
        }
    }
}
