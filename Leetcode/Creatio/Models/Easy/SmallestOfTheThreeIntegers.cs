using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SmallestOfTheThreeIntegers // Without Comparison Operators
    {
        public static int Method(int x,int y,int z)
        {
            int resp = 0;
            while(x!=0 && y!= 0 && z!= 0)
            {
                x--;
                y--;
                z--;
                resp++;
            }
            return resp;
        }
    }
}
