﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums) //[-1,0,1,2,-1,-4] ---> [[-1,-1,2] , [-1,0,1]]
        {
            IList<IList<int>> output = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1]) continue;
                //a + b + c = 0
                int sum = 0 - nums[i];
                int x = i + 1;
                int y = nums.Length - 1;
                while (x < y)
                { 
                    if (nums[x] + nums[y] == sum)
                    {
                        output.Add(new List<int>(new int[] {nums[i], nums[x], nums[y] }));
                        x++;
                        y--;
                        while (x < nums.Length && nums[x] == nums[x - 1]) x++;
                        while (y >= 0 && nums[y] == nums[y + 1]) y--;
                    }
                    else if (nums[x] + nums[y] > sum)
                        y--;
                    else
                        x++;
                }
            }
            return output;
        }
    }
}
