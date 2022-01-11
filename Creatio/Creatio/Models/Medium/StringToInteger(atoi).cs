using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class StringToInteger_atoi_
    {
        public static int MyAtoi(string s) // Not Understand(
        {
            List<char> list = new List<char>(s);
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == '-' && char.IsDigit(list[i + 1]))
                { 
                    continue;
                }
                if (!char.IsDigit(list[i]))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            string resp = "";
            foreach (var item in list)
            {
                resp += item;
            }

            return int.Parse(resp);
        }
    }
}
