using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class RemoveElement
    {
        public static int RemoveElementMethod(int[] nums, int val)
        {
            List<int> list = new List<int>(nums);
            if (!list.Contains(val))
            {
                return list.Count;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == val)
                {
                    list.RemoveAt(i);
                }
            }
            return list.Count;
        }
    }
}
