using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SummaryRangers
    {
        public static IList<string> SummaryRanges(int[] nums) // [0,2,3,4,6,8,9]
        {
            IList<string> list = new List<string>();
            int i = 0;
            while (i < nums.Length)
            {
                int start,end;

                start = nums[i];
                while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1) i++;
                end = nums[i];

                if(start == end)
                {
                    list.Add(start.ToString());
                }
                else
                {
                    list.Add($"{start}->{end}");
                }
                i++;
            }

            foreach (var item in list)
            {
                Console.WriteLine("listin itemleri:{0}",item);
            }


            return list;
        }
    }
}
