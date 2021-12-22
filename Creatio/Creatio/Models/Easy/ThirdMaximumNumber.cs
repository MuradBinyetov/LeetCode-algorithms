using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            SortedList<int, int> sortList = new SortedList<int, int>();
             

            for (int i = 0; i < nums.Length; i++)
            {
                if (!sortList.ContainsKey(nums[i]))
                {
                    sortList.Add(nums[i],i);
                }
            }
             
            if (sortList.Count() >= 3)
            {
                return 1;
            }
            else
            {
                return sortList.LastOrDefault().Value;
            }
        }
    }
}
