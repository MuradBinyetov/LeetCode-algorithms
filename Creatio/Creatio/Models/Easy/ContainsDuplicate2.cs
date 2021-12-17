using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ContainsDuplicate
    {
        public static bool ContainsDuplicateMethod(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int f = i+1; f < nums.Length; f++)
                {
                    if (nums[i] == nums[f]) return true; 
                }
            }
            return false;
        }
    }
}
