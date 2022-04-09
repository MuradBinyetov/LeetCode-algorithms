using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ArrayMaxElements
    {
        public static List<int> MaxElements(int[] arr)
        {
            List<int> resp = new List<int>();
            int max = int.MinValue;

            Array.Sort(arr);

            resp.Add(arr[arr.Length - 1]);
            resp.Add(arr[arr.Length - 2]);
             

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return resp;
        }

        public static List<int> MaxElements2(int[] arr)
        {
            List<int> resp = new List<int>();

            int max = int.MinValue;
            int removeIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]> max)
                {
                    max = arr[i];
                    removeIndex = i;
                }
            }
            resp.Add(max);

            arr = arr.Where((source, index) => index != removeIndex).ToArray();

            int max2 = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max2)
                {
                    max2 = arr[i]; 
                }
            }
            resp.Add(max2);


            return resp;
        }
    }
}
