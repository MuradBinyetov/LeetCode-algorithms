using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MergeSortedArray
    {
        
        /// nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        //  Output: [1,2,2,3,5,6]

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var nums1Length = m + n; 
            Array.Resize(ref nums1, nums1Length);
            foreach (var item in nums2)
            {
                nums1[m] = item;
                m++;
            }
            Array.Sort(nums1);
        }
    }
}
