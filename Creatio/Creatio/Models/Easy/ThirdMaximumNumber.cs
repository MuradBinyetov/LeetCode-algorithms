using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            SortedList<int, int> sortList = new SortedList<int, int>();
             

            for (int i = 0; i < nums.Length; i++)
            {
                if (!sortList.ContainsKey(nums[i]))
                {
                    sortList.Add(nums[i],i);
                }
            }

            Stack<int> stack = new Stack<int>();

            foreach (var item in sortList)
            {
                stack.Push(item.Key);
            }

            if (stack.Count() >= 3)
            {
                stack.Pop();
                stack.Pop();
                return stack.Pop();
            }
            else
            {
                return stack.Pop();
            }
        }
    }
}
