using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarrenGarbage
{
    public static class Utils
    {
        public static string RepeatString(string value, int num)
        {
            string ret = string.Empty;
            for (int i = 0; i < num; i++)
                ret += value;
            return ret;
        }
    }
}
