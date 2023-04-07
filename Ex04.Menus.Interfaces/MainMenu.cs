using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_MenuName;
        public string MenuName {
            get {
                return m_MenuName;
            }
        }

        public MainMenu(string i_Text)
        {
            m_MenuName = i_Text;
        }


        private List<MenuItem> m_MenuItems = new List<MenuItem>();
        public List<MenuItem> Items {
            get {
                return m_MenuItems;
            }
        }


        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            m_MenuItems.Add(i_ItemToAdd);
        }


        public void Show()
        {
            DisplayMenu(m_MenuName,m_MenuItems,"Exit");
        }


        internal static void DisplayMenu(string i_MenuName, List<MenuItem> i_MenuItems,string i_LastButtonName = "Back")
        {
            int inputAsInt = 0;
            while (inputAsInt != i_MenuItems.Count)
            {
                Console.WriteLine("Current Menu: {0}", i_MenuName);
                Console.WriteLine("=================================");
                int i = 0;
                foreach (MenuItem Item in i_MenuItems)
                {
                    Console.WriteLine(i.ToString() + ": " + Item.Text);
                    i++;
                }
                Console.WriteLine(i.ToString() + ": " + i_LastButtonName);
                Console.WriteLine("=================================");
                Console.WriteLine("Please choose one of the options (Between 0 and {0} please)", i);
                string inputString = Console.ReadLine();
                inputAsInt = int.Parse(inputString);
                Console.Clear();
                if (inputAsInt == i)
                    return;
                if (inputAsInt < 0 || inputAsInt > i_MenuItems.Count)
                    Console.WriteLine("Invalid Input");
                else
                    i_MenuItems[inputAsInt].ButtonClick();
            }
        }
    }
}
