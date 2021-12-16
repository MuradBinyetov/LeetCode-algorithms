using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            SortedList<int, int> sortedList = new SortedList<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;

                sortedList.Add(nums[i], i);
            } 
            sortedList.Add(target, nums.Length+1);

            return sortedList.IndexOfKey(target); 
        }
    }
}
