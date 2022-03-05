using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PickingNumbers_HACKERRANK_
    {
        public static int pickingNumbers(List<int> a) //4 6 5 3 3 1 --> 1 2 3 3 4 5 6
        { 
            a.Sort(); 
            int respCount = int.MinValue;

            for (int i = 0; i < a.Count; i++)
            {
                int count = 1;
                for (int f = i+1; f < a.Count; f++)
                {
                    if (a[f] - a[i] <= 1)
                    {
                        count++;
                        if (count > respCount)
                        {
                            respCount = count;
                        }
                    }
                    else
                    { 
                        break;
                    }
                } 
            }

            return respCount;
        }
    }
}
