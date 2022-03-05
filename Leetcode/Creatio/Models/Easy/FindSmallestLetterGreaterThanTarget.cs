using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FindSmallestLetterGreaterThanTarget
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            Array.Sort(letters);
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > target)
                {
                    return letters[i];
                } 
            }
            return letters[0];
        }
    }
}
