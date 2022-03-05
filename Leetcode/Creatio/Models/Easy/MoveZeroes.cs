using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MoveZeroes
    {
        public static int[] MoveZeroesMethod(int[] nums)
        {
            Queue<int> queue = new Queue<int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    queue.Enqueue(nums[i]);
                }
            }

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(0);
            }
            return nums = queue.ToArray();
            
        }
    }
}
