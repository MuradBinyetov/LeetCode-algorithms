using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DetectCapital
    {
        public static bool DetectCapitalUse(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                var value = (int)word[i];
                if (value >= 65 && value <= 90)
                {
                    continue;
                }
                else
                {
                    if (i > 1 && value>=97 && value<=122)
                    {
                        return false;
                    }

                }

            } 
               

                   
            return true;
        }
    }
}
