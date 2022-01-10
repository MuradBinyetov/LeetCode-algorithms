using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MostCommonWord
    {
        public static string MostCommonWordMethod(string paragraph, string[] banned)
        {
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (!char.IsLetter(paragraph[i]) && paragraph[i] != ' ')
                {
                    paragraph = paragraph.Remove(i, 1);
                    paragraph = paragraph.Insert(i, " ");
                }
            }
            SortedList<string, int> dict = new SortedList<string, int>();
            string[] chars = { " " };
            List<string> sentence = paragraph.ToLower().Split(chars, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < sentence.Count; i++)
            {
                int count = 1;
                for (int f = i + 1; f < sentence.Count; f++)
                {
                    if (sentence[i] == sentence[f])
                    {
                        count++;
                    }
                }
                if (!dict.ContainsKey(sentence[i]))
                {
                    dict.Add(sentence[i], count);
                }
            }

            for (int i = 0; i < dict.Count; i++)
            {
                if (banned.Contains(dict.ElementAt(i).Key))
                {
                    dict.RemoveAt(i);
                    i--;
                }
            }

            var a = dict.OrderByDescending(d => d.Value).FirstOrDefault().Key;
            return a;
        }
    }
}
