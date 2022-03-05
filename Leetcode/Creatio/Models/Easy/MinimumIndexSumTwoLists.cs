using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MinimumIndexSumTwoLists
    {
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> list = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < list1.Length; i++)
            {
                for (int f = 0; f < list2.Length; f++)
                {
                    if(list1[i] == list2[f])
                    {
                        dict.Add(list1[i], i + f);
                        break;
                    }
                }
            }

            int min = dict.FirstOrDefault().Value;
            foreach (var item in dict)
            {
                if(item.Value< min)
                {
                    min = item.Value;
                }
            }
            var a = dict.Where(v => v.Value == min);

            foreach (var item in a)
            {
                list.Add(item.Key);
            }
            return list.ToArray();

        }
    }
}
