using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ReorderDataLogFiles
    {
        public static string[] ReorderLogFiles(string[] logs) //{ "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" }
        {
            List<string> resp = new List<string>();
            List<string> stringList = new List<string>();

            foreach (var log in logs)
            {
                List<string> list = log.Split(' ').ToList();
                int n;
                bool isNumeric = int.TryParse(list[1], out n);

                if (!isNumeric)
                {
                    stringList.Add(log);
                } 
            }


            for (int i = 0; i < stringList.Count-1; i++)
            { 
                for (int j = i+1; j < stringList.Count; j++)
                { 
                    if (String.Compare(stringList[i], stringList[j]) < 0)
                    {
                        continue;
                    } 
                }
                resp.Add(stringList[i]);


            }

            return resp.ToArray();
        }
    }
}
