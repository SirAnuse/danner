using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarrenGarbage.MenuInputs
{
    public abstract class MenuInput
    {
        public virtual string InputName { get; set; }

        public bool Highlighted { get; set; }
        public bool Selected { get; set; }

        public abstract void Draw();
        public abstract void ChangeValue(int index);
    }
}
