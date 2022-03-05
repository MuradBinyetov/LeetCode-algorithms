using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MouseCat_HACKERRANK_
    {
        public static string catAndMouse(int x, int y, int z)
        {
            int a = Math.Abs(z - x);
            int b = Math.Abs(z - y);

            if (a < b)
            {
                return "Cat A";
            }
            else if (a > b)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            } 
        }
    }
}
