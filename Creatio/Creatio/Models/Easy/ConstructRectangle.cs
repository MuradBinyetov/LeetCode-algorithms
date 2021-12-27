using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ConstructRectangle
    {
        public static int[] ConstructRectangleMethod(int area)
        {
            int[] ans = { area, 1 };
            for (int i = 1; i * i <= area; i++)
            {
                if (area % i == 0 && (area / i - i) < (ans[0] - ans[1]))
                {
                    ans[0] = area / i;
                    ans[1] = i;
                }
            }
            return ans;
        }
    }
}
