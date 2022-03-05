using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class RepeatedSubstringPattern
    {
        public static bool RepeatedSubstringPatternMethod(string s) //"abaababaab"
        {
            if (s == null || s.Length <= 1)
            {
                return false;
            }
            int len = s.Length;
            for (int i = 1; i <= len / 2; i++)
            {
                if (len % i != 0)
                {
                    continue;
                }
                String str = s.Substring(0, i);
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < len / i; j++)
                {
                    sb.Append(str);
                }
                if (s.Equals(sb.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
