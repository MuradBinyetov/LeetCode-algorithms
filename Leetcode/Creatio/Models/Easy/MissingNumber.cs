using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MissingNumber
    {
        public static int MissingNumberMethod(int[] nums) // [9,6,4,2,3,5,7,0,1]
        {
            SortedList<int, int> sortedList = new SortedList<int, int>();

            for (int i = 0; i <= nums.Length; i++)
            {
                sortedList.Add(i, i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (sortedList.ContainsKey(nums[i]))
                {
                    sortedList.Remove(nums[i]);
                }
            }

            return sortedList.FirstOrDefault().Key;
        }
    }
}
