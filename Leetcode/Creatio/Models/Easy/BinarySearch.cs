using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)  //Linear Search
        {
            if (!nums.Contains(target)) return -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            } 
            return -1;
        }

        public static int BinarySrach2(int[] nums,int target) //BinarySearch  // [3,6,7,9,12]
        {
            Array.Sort(nums);
            int left = 0;  // 0   0  1
            int right = nums.Length - 1; // 4   1  1

            while (left <= right)
            {
                int midIndex = left + (right -left) / 2; //2  0  1
                if (target == nums[midIndex]) return midIndex;

                else if(nums[midIndex] > target)
                {
                    right = midIndex-1;
                }
                else
                {
                    left = midIndex+1;
                }
            }

            return -1;


        }

    }
}
