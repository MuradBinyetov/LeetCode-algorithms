using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SortArrayParityII
    {
        public static int[] SortArrayByParityII(int[] nums) //[4,2,5,7] --> [4,5,2,7]
        {
            int j = 1;
            for (int i = 0; i < nums.Length; i += 2)
            {
                if (nums[i] % 2 == 1)
                {
                    while (nums[j] % 2 == 1)
                        j += 2;

                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                }
            }
                

            return nums;
        }
    }
}
