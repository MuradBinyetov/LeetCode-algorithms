using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SetMismatch
    {
        public static int[] FindErrorNums(int[] nums)
        {
            List<int> newNums = new List<int>();
            List<int> resp = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                newNums.Add(i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int f = i+1; f < nums.Length; f++)
                {
                    if(nums[i]== nums[f])
                    {
                        count++;
                    }
                    if (count > 0)
                    {
                        resp.Add(nums[i]);
                        break;
                    }
                } 
            }


            foreach (var item in newNums)
            {
                if (!nums.Contains(item))
                {
                    resp.Add(item);
                    break;
                }
            }

            return resp.ToArray();
        }
    }
}
