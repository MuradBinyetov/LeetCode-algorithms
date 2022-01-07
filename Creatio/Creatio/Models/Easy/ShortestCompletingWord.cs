using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ShortestCompletingWord
    {
        public static string ShortestCompletingWordMethod(string licensePlate, string[] words) //"1s3 PSt"    ["step","steps","stripe","stepple"]
        {
            List<char> list = new List<char>();
            SortedList<int,string> wrds = new SortedList<int, string>();

            foreach (var item in licensePlate)
            {
                if (char.IsLetter(item))
                {
                    list.Add(char.ToLower(item));
                }
            } 
            
            for (int i = 0; i < words.Length; i++)
            {
                List<char> removedList = new List<char>(list);
                for (int f = 0; f < words[i].Length; f++)
                {
                    if (removedList.Contains(words[i][f]))
                    {
                        removedList.Remove(words[i][f]);
                    }
                }
                if(removedList.Count == 0)
                {
                    if (!wrds.ContainsKey(words[i].Length))
                    {
                        wrds.Add(words[i].Length, words[i]);
                    } 
                }
            }             
            return wrds.FirstOrDefault().Value;
        }
    }
}
