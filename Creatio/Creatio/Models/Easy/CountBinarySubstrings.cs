using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class CountBinarySubstrings
    {
        public static int CountBinarySubstringsMethod(string s)
        {
            if (String.IsNullOrEmpty(s)) return 0;

            int numberConsecutiveOnes = 0;
            int numberConsecutiveZeroes = 0;
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (i - 1 >= 0 && s[i - 1] == '1') numberConsecutiveZeroes = 0;
                    numberConsecutiveZeroes++;
                    if (numberConsecutiveZeroes <= numberConsecutiveOnes) result++;
                }
                else
                {
                    if (i - 1 >= 0 && s[i - 1] == '0') numberConsecutiveOnes = 0;
                    numberConsecutiveOnes++;
                    if (numberConsecutiveOnes <= numberConsecutiveZeroes) result++;
                }
            }

            return result;
        }
    }
}
