using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarrenGarbage.Screens
{
    class OptionsMenu : Screen
    {
        public override string ScreenID { get { return "OPTIONS_MENU"; } }
        public OptionsMenu()
        {
        }

        public override void Run()
        {
            Console.WriteLine("yeet");
            string menuHeader = " ______  ___  ____________ _____ _   _  ____________ _____ 				\n" +
                            " |  _  \\/ _ \\ | ___ \\ ___ \\  ___| \\ | | | ___ \\ ___ \\  __ \\		\n" +
                            " | | | / /_\\ \\| |_/ / |_/ / |__ |  \\| | | |_/ / |_/ / |  \\/			\n" +
                            " | | | |  _  ||    /|    /|  __|| . ` | |    /|  __/| | __ 				\n" +
                            " | |/ /| | | || |\\ \\| |\\ \\| |___| |\\  | | |\\ \\| |   | |_\\ \\	\n" +
                            " |___/ \\_| |_/\\_| \\_\\_| \\_\\____/\\_| \\_/ \\_| \\_\\_|    \\____/	\n" +
                            $" -=-=-=-=-=-=- v{Program.VERSION} :: Created by Rustiniz -=-=-=-=-=-=-";

            //string input = Inputs.MenuInput(menuHeader, new string[] { "Audio", "Select Style", "Back" }, false, MenuInputStyles.SpacedArrow);

            /*switch (input)
            {
                case "Back":
                    GoToScreen("MAIN_MENU");
                    break;
            }*/
        }
    }
}
