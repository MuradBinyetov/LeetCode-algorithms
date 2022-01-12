using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class IntegerToRoman
    {
        public static string IntToRoman(int num) // 58 -->LVIII
        {
            int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < val.Length; i++)
            {
                while (num >= val[i])
                {
                    num -= val[i];
                    sb.Append(strs[i]);
                }
            }
            return sb.ToString();
        } 
    }
}
