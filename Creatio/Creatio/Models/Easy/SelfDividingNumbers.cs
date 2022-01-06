using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SelfDividingNumbers
    {
        public static IList<int> SelfDividingNumbersMethod(int left, int right)
        {
            IList<int> list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                left = i;
                while (left > 0)
                {
                    int qaliq = left % 10; 
                    if(qaliq == 0 || i%qaliq != 0)
                    {
                        break;
                    }
                    left = (left - qaliq) / 10;
                }
                if(left == 0)
                {
                    list.Add(i);
                }
            } 
            return list;
        }
    }
}
