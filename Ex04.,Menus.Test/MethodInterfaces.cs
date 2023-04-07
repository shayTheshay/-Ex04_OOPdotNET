using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
        public class ShowVersionButton : Interfaces.IButtonFunctionality
        {
            public void OnClick()
            {
                ButtonMethods.ShowVersion();
            }
        }

        public class CountUppercaseButton : Interfaces.IButtonFunctionality
        {
            public void OnClick()
            {
               ButtonMethods.CountUppercase();
            }
        }

        public class ShowDateButton : Interfaces.IButtonFunctionality
        {
            public void OnClick()
            {
                ButtonMethods.ShowDate();
            }
        }

        public class ShowTimeButton : Interfaces.IButtonFunctionality
        {
            public void OnClick()
            {
                 ButtonMethods.ShowTime();
            }
        }

    }

