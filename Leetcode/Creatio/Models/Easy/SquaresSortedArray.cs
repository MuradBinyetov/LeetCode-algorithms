using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SquaresSortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            List<int> respArr = new List<int>();
            int[] resp = { };
            for (int i = 0; i < nums.Length; i++)
            {
                respArr.Add(nums[i] * nums[i]);
            }
            resp = respArr.ToArray();
            Array.Sort(resp);
            return resp;
        }
    }
}
