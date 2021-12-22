using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class AddDigits
    {
        public static int AddDigitsMethod(int num)
        {
            int sum = 0; 
            while (num > 0)
            { 
                int lastNum = num % 10;
                num = (num - lastNum) / 10;
                sum += lastNum; 
                if(sum >= 10 && num == 0)
                {
                    num = sum;
                    sum = 0; 
                }
            } 
            return sum;
        }
    }
}
