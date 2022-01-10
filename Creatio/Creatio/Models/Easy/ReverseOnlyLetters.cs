using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ReverseOnlyLetters
    {
        public static string ReverseOnlyLettersMethod(string s) // "Test1ng-Leet=code-Q!"  ---> "Qedo1ct-eeLg=ntse-T!"
        {
            LinkedList<char> list = new LinkedList<char>(s);

            for (int i = list.Count-1; i >= 0; i--)
            {
                if (char.IsLetter(list.ElementAt(i)))
                {
                    var lastElem = list.Last();
                    char firstElem = list.First();
                    
                    if (char.IsLetter(firstElem))
                    {
                        list.AddFirst(list.ElementAt(i));
                    }
                }
                else
                {
                    continue;
                }
            }
            return "";
        }
    }
}
