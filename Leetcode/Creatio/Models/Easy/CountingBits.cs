using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class CountingBits
    {
        public static int[] CountBits(int n)
        {
            List<int> list = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                int num = i;
                int sum = 0;
                if (i == 0)
                {
                    list.Add(sum);
                }
                else
                {
                    while (num >= 1)
                    {
                        int qaliq = num % 2;
                        sum += qaliq;
                        num = num / 2;
                    }
                    list.Add(sum);
                    continue;
                } 
            } 

            return list.ToArray();
        }
    }
}
