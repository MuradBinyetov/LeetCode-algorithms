using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LemonadeChange
    {
        public static bool LemonadeChangeMethod(int[] bills)
        {
            if (bills[0] != 5) return false;

            int five = 0;
            int ten = 0;
            foreach (int bill in bills)
            {
                if (bill == 5)
                    five++;

                else if (bill == 10)
                {
                    if (five == 0) return false;
                    five--;
                    ten++;
                }
                else 
                {
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
