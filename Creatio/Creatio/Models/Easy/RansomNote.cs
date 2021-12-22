using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class RansomNote
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> ransomNoteChars = new List<char>(ransomNote); 
            List<char> magazineChars = new List<char>(magazine); 
            for (int i = 0; i < ransomNoteChars.Count; i++)
            {
                if (magazineChars.Contains(ransomNoteChars[i]))
                {
                    magazineChars.Remove(ransomNoteChars[i]);
                    continue;
                }
                else
                {
                    return false;
                }
            }  
            return true;
        }
    }
}
