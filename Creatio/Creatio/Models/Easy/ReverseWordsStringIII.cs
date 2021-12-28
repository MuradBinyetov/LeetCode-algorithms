using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ReverseWordsStringIII
    {
        public static string ReverseWords(string s)
        {
            string[] wordList = s.Split(' ');
            string reverseWord = "";
            foreach (var item in wordList)
            {
                for (int i = item.Length-1; i >=0; i--)
                {
                    reverseWord += item[i]; 
                }
                reverseWord += " "; 
            }

            return reverseWord.TrimEnd();
        }
    }
}
