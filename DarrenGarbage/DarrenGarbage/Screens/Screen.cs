using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarrenGarbage.Screens
{
    public abstract class Screen
    {
        public static Dictionary<string, Screen> Screens = new Dictionary<string, Screen>();

        private string screenId;
        public virtual string ScreenID { get { return screenId; } set { screenId = value; } }

        public Screen()
        {
            Screens.Add(ScreenID, this);
        }

        
        public abstract void Run();

        public static void LoadScreens()
        {
            new OptionsMenu();
            new MainMenu();
        }

        public static void GoToScreen(string screenId)
        {
            // TODO: Put error message when screen not found
            if (!Screens.ContainsKey(screenId))
            {
                Console.WriteLine("well jon");
                return;
            }

            Screens[screenId].Run();
        }
    }
}
