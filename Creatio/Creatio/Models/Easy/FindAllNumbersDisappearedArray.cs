using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FindAllNumbersDisappearedArray
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)  //[4,3,2,7,8,2,3,1]
        {
            IList<int> list = new List<int>();
            int max = nums[0]; 
            

            for (int i = 1; i <= nums.Length; i++)
            {
                list.Add(i);
            } 
            

            for (int i = 0; i < list.Count; i++)
            {
                if (nums.Contains(list[i]))
                {
                    list.Remove(list[i]);
                    i--;
                }
            }


            return list;
        }
    }
}
