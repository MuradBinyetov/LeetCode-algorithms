using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums) //0,0,1,1,1,2,2,3,3,4
        {
            if (nums.Length == 0 || nums.Length == 1)
                return nums.Length;
            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                    nums[++index] = nums[i];
            }
            return index + 1;
        }
    }
}
