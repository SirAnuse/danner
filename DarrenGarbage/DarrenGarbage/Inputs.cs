/*
 * Created by SharpDevelop.
 * User: DEV0003
 * Date: 28/05/2019
 * Time: 10:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using DarrenGarbage.MenuInputs;
using Console = Colorful.Console;

namespace DarrenGarbage
{
    public enum MenuInputStyles
    {
        Highlight,
        Arrow,
        SpacedArrow
    }

    public class Menu
    {
        private List<MenuInput> menuItems;
        private string headerText;
        public Menu(string headerText, List<MenuInput> menuItems)
        {
            this.menuItems = menuItems;
            this.headerText = headerText;
            Run();
        }

        public void Run()
        {
            int index = 0;
            while (true)
            {
                Console.Clear();
                
                Console.WriteLine(headerText);

                foreach (var i in menuItems)
                {
                    i.Highlighted = i == menuItems[index] && !menuItems[index].Selected;
                    i.Draw();
                }

                int indexInput = GetIndexInput(index, menuItems.Count);

                if (indexInput == -1)
                    menuItems[index].Selected = !menuItems[index].Selected;
                else if (indexInput == -2 || indexInput == -3)
                {
                    if (menuItems[index].Selected)
                        menuItems[index].ChangeValue(indexInput);
                }
                else
                    index = indexInput;
            }
        }

        public static int GetIndexInput(int index, int max, bool overflow = false)
        {
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    return index > 0 ? index - 1 : overflow ? max - 1 : index;
                case ConsoleKey.DownArrow:
                    // basically don't overflow if overflow is disabled, do if it is
                    // to get the grasp of what this is, it's a nested ternary
                    return index < max - 1 ? index + 1 : overflow ? 0 : index;
                case ConsoleKey.Enter:
                    // -1 = enter
                    return -1;
                case ConsoleKey.LeftArrow:
                    return -2;
                case ConsoleKey.RightArrow:
                    return -3;
                default:
                    // -2 = other key
                    return index;
            }
        }
    }
}
