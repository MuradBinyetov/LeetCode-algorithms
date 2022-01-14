using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class TwoSum
    {
        public static int[] TwoSumMethod(int[] numbers, int target)
        {
            List<int> returnArr = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int f = i+1; f < numbers.Length; f++)
                {
                    if(numbers[i] + numbers[f] == target)
                    {
                        returnArr.Add(i);
                        returnArr.Add(f);
                        return returnArr.ToArray();
                    }
                }
            } 
            return returnArr.ToArray();
        }
    }
}
