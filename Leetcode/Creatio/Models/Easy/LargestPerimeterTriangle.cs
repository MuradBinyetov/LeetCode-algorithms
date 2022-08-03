using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LargestPerimeterTriangle
    {
        public static int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);

            for (int i = nums.Length-3 ; i >=0; --i)
            {
                if(nums[i] + nums[i + 1] > nums[i + 2])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }
            return 0;
        }
    }
}
