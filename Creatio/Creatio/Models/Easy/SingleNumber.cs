using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class SingleNumber
    {
        public static int SingleNumberMethod(int[] nums) // [4,1,2,1,2,1]
        {
            List<int> list = new List<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            { 
                for (int f = i+1; f < nums.Length; f++)
                {
                    if(nums[i] == nums[f])
                    {
                        list.Remove(nums[i]);
                        list.Remove(nums[f]);
                    }
                }
            }
             
            return list[0];
        }
    }
}
