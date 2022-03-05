using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            if (!nums.Contains(target)) return -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            } 
            return -1;
        }
    }
}
