using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DetectCapital
    {
        public static bool DetectCapitalUse(string word)   // UpperCase = [65-->90]  LowerCase = [97 --> 122]
        { 
            var first = (int)word[0];
            var second = (int)word[1];

            if (word.Length == 1) return true;

            if(first>=65 && first <= 90) // ilk herf boyukduse
            {
                if(second >= 65 && second <= 90)  //2ci herf boyukduse
                {
                    for (int i = 2; i < word.Length; i++)
                    {
                        if(word[i] >=97 && word[i] <= 122)
                        {
                            return false;
                        }
                        if(word[i]>=65 && word[i] <= 90)
                        {
                            continue;
                        }
                    }
                } 
                if(second>=97 && second <= 122)  //2 ci herf kicikdise
                {
                    for (int i = 2; i < word.Length; i++)
                    {
                        if (word[i] >= 97 && word[i] <= 122)
                        {
                            continue;
                        }
                        if (word[i] >= 65 && word[i] <= 90)
                        {
                            return false;
                        }
                    }
                }
            }
            if(first >= 97 && first <= 122)
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] >= 97 && word[i] <= 122)
                    {
                        continue;
                    }
                    if (word[i] >= 65 && word[i] <= 90)
                    {
                        return false;
                    }
                }
            }

            return true; 
        }
    }
}
