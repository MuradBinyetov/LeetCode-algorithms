using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class AddArrayFormInteger
    {
        public static IList<int> AddToArrayForm(int[] num, int k) //[1,3,2,1]
        {    
            List<int> resp = new List<int>();

            int i = num.Length;
            while (--i >= 0 || k > 0)
            {
                if (i >= 0)
                    k += num[i];
                resp.Add(k % 10);
                k /= 10;
            }
            resp.Reverse();
            return resp;
        }
    }
}
