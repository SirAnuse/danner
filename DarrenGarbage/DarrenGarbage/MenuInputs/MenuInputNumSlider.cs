using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarrenGarbage.MenuInputs
{
    public class MenuInputNumSlider : MenuInput
    {
        private string inputName;
        public override string InputName { get => inputName; set => inputName = value; }

        private int min { get; set; }
        private int max { get; set; }
        private int step { get; set; }
        private int value { get; set; }

        public MenuInputNumSlider(string inputName, int value, int min, int max, int step)
        {
            this.min = min;
            this.max = max;
            this.step = step;
            this.value = value;
            InputName = inputName;
        }

        public override void ChangeValue(int index)
        {
            switch (index)
            {
                // left arrow
                case -2:
                    value = Math.Max(min, value - step);
                    break;
                case -3:
                    value = Math.Min(max, value + step);
                    break;
            }
        }

        public override void Draw()
        {
            Graphics.DrawInput(InputName, getValueString(), Selected, Highlighted);
        }

        private string getValueString()
        {
            return Utils.RepeatString("=", (int)((float)value / max * 10)) + Utils.RepeatString("-", (int)(((float)max - value) / max * 10));
        }
    }
}
