using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class TwoMinIntegersFromArray
    {
        public static List<int> Method(int[] arr)
        {
            List<int> list = new List<int>();

            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (firstMin > arr[i])
                {
                    secondMin = firstMin;
                    firstMin = arr[i];
                }

                else if(arr[i]<secondMin && arr[i] != firstMin)
                {
                    secondMin = arr[i];
                }
            } 
            return list;
        }
    }
}
