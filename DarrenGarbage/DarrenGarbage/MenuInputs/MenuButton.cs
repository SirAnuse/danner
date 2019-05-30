using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarrenGarbage.MenuInputs
{
    public class MenuButton : MenuInput
    {
        private string inputName;
        public override string InputName { get => inputName; set => inputName = value; }

        public MenuButton(string inputName)
        {
            InputName = inputName;
        }

        public override void ChangeValue(int index)
        {
        }

        public override void Draw()
        {
            Graphics.DrawInput(InputName, string.Empty, Selected, Highlighted);
        }
    }
}
