using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ReverseOnlyLetters
    {
        public static string ReverseOnlyLettersMethod(string s) // "Test1ng-Leet=code-Q!"  ---> "Qedo1ct-eeLg=ntse-T!"
        {
            Stack<char> letters = new Stack<char>();
            foreach (char c in s.ToCharArray())
            {
                if (Char.IsLetter(c))
                {
                    letters.Push(c);
                } 
            }
               

            StringBuilder ans = new StringBuilder();
            foreach (char c in s.ToCharArray())
            {
                if (char.IsLetter(c))
                {
                    ans.Append(letters.Pop());
                }
                else
                {
                    ans.Append(c);
                } 
            }

            return ans.ToString();
        }
    }
}
