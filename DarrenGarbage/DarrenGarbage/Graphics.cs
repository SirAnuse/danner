using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;

namespace DarrenGarbage
{
    static class Graphics
    {
        private static Color _color = Color.White;
        public static void SetColor(Color color) => _color = color;
        public static void DrawInput(string text, string value, bool selected, bool highlighted)
        {
            Console.Write($"{text}    ", highlighted ? _color : Color.Gray);
            if (!String.IsNullOrEmpty(value))
                Console.Write($"{value}", selected ? _color : Color.Gray);
            Console.Write("\n");
        }
    }
}
