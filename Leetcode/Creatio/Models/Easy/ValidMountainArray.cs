using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ValidMountainArray
    {
        public static bool ValidMountainArrayMethod(int[] arr)
        {
            if(arr.Length < 3) return false;
            if (arr[0] >= arr[1]) return false;
            bool inCreasing = true;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1]) return false;

                if (inCreasing)
                {
                    if (arr[i + 1] > arr[i])
                    {
                        continue;
                    }
                    else
                    {
                        inCreasing = false;
                    }
                }
                else
                {
                    if (arr[i + 1] > arr[i])
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            if (inCreasing) return false;
            return true;
        }
    }
}
