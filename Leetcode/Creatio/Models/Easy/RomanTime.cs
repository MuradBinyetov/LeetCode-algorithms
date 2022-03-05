using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class RomanTime
    {

        public static int RomanToInt(string str) //MCMXCIV
        {
            int res = 0;
            Dictionary<char, int> dic = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 } 
            };

            for (int i = 0; i < str.Length; ++i)
            {
                int val = dic[str[i]];
                if (i == str.Length - 1 || dic[str[i + 1]] <= dic[str[i]])
                {
                    res += val;
                }
                else
                {
                    res -= val;
                }
            }
            return res;
        }

    }
}
