using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DarrenGarbage.MenuInputs;

namespace DarrenGarbage.Screens
{
    class MainMenu : Screen
    {
        public override string ScreenID { get { return "MAIN_MENU"; } }
        public MainMenu()
        {
        }

        public override void Run()
        {
            string menuHeader = " ______  ___  ____________ _____ _   _  ____________ _____ 				\n" +
                            " |  _  \\/ _ \\ | ___ \\ ___ \\  ___| \\ | | | ___ \\ ___ \\  __ \\		\n" +
                            " | | | / /_\\ \\| |_/ / |_/ / |__ |  \\| | | |_/ / |_/ / |  \\/			\n" +
                            " | | | |  _  ||    /|    /|  __|| . ` | |    /|  __/| | __ 				\n" +
                            " | |/ /| | | || |\\ \\| |\\ \\| |___| |\\  | | |\\ \\| |   | |_\\ \\	\n" +
                            " |___/ \\_| |_/\\_| \\_\\_| \\_\\____/\\_| \\_/ \\_| \\_\\_|    \\____/	\n" +
                            $" -=-=-=-=-=-=- v{Program.VERSION} :: Created by Rustiniz -=-=-=-=-=-=-";

            var slider = new MenuInputNumSlider("Test", 1, 0, 10, 1);
            var button = new MenuButton("Testosterone");
            var menu = new Menu(menuHeader, new List<MenuInput>(new MenuInput[] { slider, button }));
            //string input = new MenuInput(menuHeader, new string[] { "Play", "Options", "Exit" }, false, MenuInputStyles.SpacedArrow);

            /*switch (input)
            {
                case "Options":
                    GoToScreen("OPTIONS_MENU");
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }*/
        }
    }
}
