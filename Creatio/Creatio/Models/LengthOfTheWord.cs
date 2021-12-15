using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class LengthOfTheWord
    {
        public static int LengthOfLastWord(string s) // s = "Today is a nice day   " 
        {
            Stack<char> list = new Stack<char>();
            
            int count = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                list.Push(s[i]); 
            }

            foreach (var item in list)
            {
                if (count == 0 && item == ' ')
                {
                    count = 0;
                    continue;
                }
                if (item == ' ') break;
                count++;
                if (count > max)
                {
                    max = count;
                }
            }
            return max;
        }
    }
}
