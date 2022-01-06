using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LargestNumberLeastTwiceOthers
    {
        public static int DominantIndex(int[] nums)
        {
            if (nums.Length == 1) return 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = nums[0];
            dict.Add(max, 0);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    dict.Clear();
                    max = nums[i];
                    dict.Add(max, i);
                }
            }

            var maxNum = dict.FirstOrDefault();

            foreach (var item in nums)
            {
                if(item != maxNum.Key)
                {
                    if (item * 2 > maxNum.Key)
                        return -1;
                }
            }
            
            return maxNum.Value;
        }
    }
}
