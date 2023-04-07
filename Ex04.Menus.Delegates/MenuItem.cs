using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Ex04.Menus.Delegates
{
    public delegate void ButtonFuncionality();
    public class MenuItem
    {
        private readonly string r_SubTitle;
        private List<MenuItem> m_MenuItems = new List<MenuItem>();
        public List<MenuItem> Items {
            get {
                return m_MenuItems;
            }
        }
        public readonly string SubBack = "Back";
        public int NumberSelection {
            get;
            set; 
        }

        private event ButtonFuncionality m_NotifyCorrectMethod;

        public MenuItem(List<MenuItem> i_SubMenuList, int i_NumberSelection)
        {
            m_MenuItems = new List<MenuItem>(i_SubMenuList);
            NumberSelection = i_NumberSelection;
            r_SubTitle = "Delegates MainMenu";
            SubBack = "Exit";
            
        }
        public MenuItem(string i_GetTitle)
        {
            r_SubTitle = i_GetTitle;

        }


        public MenuItem()
        {
            r_SubTitle = "Delegates MainMenu";
            SubBack = "Exit";
        }

        public MenuItem(List<MenuItem> i_SubMenuList, string i_SubTitle, int i_NumberSelection)
        {
            m_MenuItems = new List<MenuItem>(i_SubMenuList);
            r_SubTitle = i_SubTitle;
            NumberSelection = i_NumberSelection;
        }


        protected virtual void OnButtonClick()
        {
            if (m_MenuItems.Count > 0)
                DisplayMenu(r_SubTitle, m_MenuItems, "Back");
            if(m_NotifyCorrectMethod != null)
                m_NotifyCorrectMethod.Invoke();
        }

        public void AddButtonFunctionality(ButtonFuncionality i_Functionality)
        {
            m_NotifyCorrectMethod += i_Functionality;
        }


        internal void MainMenuShow()
        {
            DisplayMenu(r_SubTitle, m_MenuItems, "Exit");
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            m_MenuItems.Add(i_ItemToAdd);
        }

        internal static void DisplayMenu(string i_MenuName, List<MenuItem> i_MenuItems, string i_LastButtonName = "Back")
        {
            int inputAsInt = 0;
            while (inputAsInt != i_MenuItems.Count)
            {
                Console.WriteLine("**Current Menu: {0}**", i_MenuName);
                Console.WriteLine("=================================");
                int i = 0;
                foreach (MenuItem Item in i_MenuItems)
                {
                    Console.WriteLine(i.ToString() + ": " + Item.r_SubTitle);
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
                    i_MenuItems[inputAsInt].OnButtonClick();
            }
        }



    }
}
