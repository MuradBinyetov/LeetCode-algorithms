using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LongPressedName
    {
        public static bool IsLongPressedName(string name, string typed) //saeed --> ssaaeedd
        {
            int i = 0;
            for (int j = 0; j < typed.Length; ++j)
            {
                if (i < name.Length && name[i] == typed[j])
                {
                    ++i;
                }
                else if (j == 0 || typed[j] != typed[j - 1])
                {
                    return false;
                }
            }
            return i == name.Length;
        }
    }
}
