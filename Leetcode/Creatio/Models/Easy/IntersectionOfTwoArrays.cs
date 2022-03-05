using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class IntersectionOfTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> returnList = new List<int>();
            List<int> list1 = new List<int>(nums1);
            List<int> list2 = new List<int>(nums2);

            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    returnList.Add(item);
                    list2.Remove(item);
                }
            }


            return returnList.Distinct().ToArray();
        }
    }
}
