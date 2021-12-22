using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ValidPerfectSquare
    {
        public static bool IsPerfectSquare(int num)
        {
            if (num < 1)
                return false;
            if (num == 1)
                return true;
            for (int i = 1; i <= num / 2; i++)
            {
                if (i * i == num)
                    return true;
            }
            return false;
        } 
    }
}
