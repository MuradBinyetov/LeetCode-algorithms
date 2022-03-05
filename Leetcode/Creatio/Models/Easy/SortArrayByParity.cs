using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SortArrayByParity
    {
        public static int[] SortArrayByParityMethod(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] %2 == 0)
                {
                    list.Add(nums[i]);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    list.Add(nums[i]);
                }
            }

            return list.ToArray();
        }
    }
}
