using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{

    public class MenuItem
    {

        private string m_Text;
        public string Text
        {
            get { return m_Text; }
        }
        private readonly List<IButtonFunctionality> m_ButtonFunctionalities = new List<IButtonFunctionality>();
        private List<MenuItem> m_MenuItems = new List<MenuItem>();

        public MenuItem(string i_Text)
        {
            m_Text = i_Text;
        }


        public MenuItem(string i_Text,List<MenuItem> i_MenuItems)
        {
            m_Text = i_Text;
            m_MenuItems = i_MenuItems;
        } 

        public MenuItem(string i_Text,IButtonFunctionality i_Functionality)
        {
            m_Text = i_Text;
            this.AddFunctionality(i_Functionality);
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            m_MenuItems.Add(i_ItemToAdd);
        }

        public void AddFunctionality(IButtonFunctionality i_Functionality)
        {
            m_ButtonFunctionalities.Add(i_Functionality);
        }

        public void ButtonClick()
        {
            if (m_MenuItems.Count > 0)
            {
                MainMenu.DisplayMenu(m_Text, m_MenuItems);
            }

            else
            {
                foreach (IButtonFunctionality functionality in m_ButtonFunctionalities)
                    functionality.OnClick();
            }

        }
    }
}
