using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class FindFirstLastPositionElementSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            List<int> list = new List<int>();

            if (!nums.Contains(target))
            {
                list.Add(-1);
                list.Add(-1);
                return list.ToArray();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    list.Add(i);
                }
            }

            var max =  list.Max();
            var min = list.Min();
            list.Clear();
            list.Add(min);
            list.Add(max);
            return list.ToArray();
        }
    }
}
