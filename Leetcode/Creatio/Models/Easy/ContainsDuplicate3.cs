using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ContainsDuplicate3
    {
        public static bool ContainsDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int f = i + 1; f < nums.Length && f < k; f++)
                {
                    if (nums[i] == nums[f]) return true;
                }
            }
            return false;
        }
    }
}
