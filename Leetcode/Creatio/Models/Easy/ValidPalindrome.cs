using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        { 
            s = s.ToLower(); 

            for (int i = 0; i < s.Length; i++)
            {
                var a = s[i];
                if (!Char.IsLetterOrDigit(s[i]) || Char.IsWhiteSpace(s[i]))
                {
                    s = s.Remove(i, 1); //A man, a plan, a canal: Panama
                    i--;
                } 
            }
            Console.WriteLine("s-in new deyeri:{0}",s);
            string revertedString = string.Empty;
            for (int i = s.Length-1; i >= 0; i--)
            {
                revertedString += s[i];
            } 

            if (s.Equals(revertedString))
            {
                Console.WriteLine("trueee");
                return true;
            }

            Console.WriteLine("falseee");
            return false;
        }
    }
}
