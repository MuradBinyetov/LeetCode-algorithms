using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class CanPlaceFlowers
    {
        public static bool CanPlaceFlowersMethod(int[] flowerbed, int n)
        {

            if (flowerbed.Length == 1) return flowerbed[0] == 0 || n == 0;
            int last = flowerbed.Length-1;


            if(flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                n--;
                flowerbed[0] = 1;
            }
            if (flowerbed[last] == 0 && flowerbed[last-1] == 0)
            {
                n--;
                flowerbed[last] = 1;
            }
            for (int i = 0; i < flowerbed.Length; i++)
            {  
                if(flowerbed[i] == 0 && flowerbed[i+1] == 0 && flowerbed[i+2] == 0)
                {
                    n--;
                    flowerbed[i + 1] = 1;
                    i = i + 2;
                } 
            }

            if (n <= 0) return true; 


            return false;
        }
    }
}
