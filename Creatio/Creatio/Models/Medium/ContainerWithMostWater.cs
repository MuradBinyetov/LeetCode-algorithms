using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] == 0) continue;
                for (int f = i+max/height[i]; f < height.Length; f++)
                {
                    if (height[f] == 0) continue;
                    if (height[i] <= height[f])
                    {
                        if(height[i] * (f - i) > max)
                        {
                            max = height[i] * (f - i);
                        }
                       
                    }
                    if (height[i] >= height[f])
                    {
                        if(height[f] * (f - i)>max)
                        {
                            max = height[f] * (f - i);
                        } 
                    }
                }
            }
            return max;
        }
    }
}
