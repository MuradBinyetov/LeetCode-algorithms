using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class SortList
    {
        public static int[] SortListMethod(int[] arr)
        { 
            List<int> list = new List<int>(arr);


            for (int i = 0; i < list.Count-1; i++)
            {
                for (int f = i+1; f < list.Count; f++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int changeNum = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = changeNum;
                    }
                } 
            } 
            return list.ToArray(); 
        }

        public static int[] SortListMethod2(string[] args)
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            return intArray;
        }
    } 
 
}
