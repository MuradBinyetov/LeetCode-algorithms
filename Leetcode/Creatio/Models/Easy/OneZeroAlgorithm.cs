using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class OneZeroAlgorithm // [1,1,0,0,1,1,0,0,0,1,0,1] --> [1,1,1,1,1,1,0,0,0,0,0]
    {
        public static int[] Method(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int f = i+1; f < array.Length; f++)
                {
                    if (Compare(i, f, array) == 1)
                    {
                        break;
                    }
                    else if(Compare(i, f, array) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        int temp = array[i];
                        array[i] = array[f];
                        array[f] = temp;
                        break;
                    } 
                } 
            }
            return array;
        }

        private static int Compare(int index1, int index2, int[] array)
        {
            if (array[index1] > array[index2])
            {
                return 1;
            }
            else if (array[index1] < array[index2])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
