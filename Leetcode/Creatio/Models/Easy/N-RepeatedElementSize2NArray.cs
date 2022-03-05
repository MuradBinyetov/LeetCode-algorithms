using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class N_RepeatedElementSize2NArray
    {
        public static int RepeatedNTimes(int[] nums)
        {  
            for (int i = 0; i < nums.Length; i++)
            {
                for (int f = i+1; f < nums.Length; f++)
                {
                    if(nums[i] == nums[f])
                    {
                        return nums[i];
                    }
                }
            }

            return 0;
        }
    }
}
