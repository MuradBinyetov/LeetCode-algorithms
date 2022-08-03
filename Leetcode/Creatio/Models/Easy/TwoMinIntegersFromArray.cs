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


        public static int[] MaxMethod(int[] arr)
        {
            int[] respArr = new int[2];
            int firstNum = int.MinValue;
            int secondNum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstNum)
                {
                    secondNum = firstNum;
                    firstNum = arr[i];
                }
                else if (secondNum < arr[i] && arr[i] != firstNum)
                {
                    secondNum = arr[i];
                }
            }
             

            respArr[0] = firstNum;
            respArr[1] = secondNum;
            return respArr;

        }
    }
}
