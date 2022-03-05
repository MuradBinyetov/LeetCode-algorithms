using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MajorityElement
    {
        public static int MajorityElementMethod(int[] nums)
        {
            SortedList<int, int> dict = new SortedList<int, int>();
            List<int> list = new List<int>(nums);

            for (int i = 0; i < list.Count; i++)
            {
                int count = 1;
                for (int f = i+1; f < list.Count; f++)
                {
                    if(list[i] == list[f])
                    { 
                        count++;
                        list.RemoveAt(f);
                        f--;
                    }
                }
                if (!dict.ContainsKey(count))
                {
                    dict.Add(count, list[i]);
                }
                
                list.Remove(list[i]);
                i--;
               
            }
            Console.WriteLine(dict.LastOrDefault().Value);
            return dict.LastOrDefault().Value;
        }
    }
}
