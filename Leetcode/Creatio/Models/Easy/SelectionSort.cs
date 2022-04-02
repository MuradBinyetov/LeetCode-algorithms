using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SelectionSort
    {
        public static int[] Sort(int[] arr) //64 25 12 22 11
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
    }
}
