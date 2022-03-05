using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LibraryFine_HACKERRANK_
    {
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int hackos = 0;

            if(d1 == d2 && m1 == m2 && y1 == y2)
            {
                hackos = 0;
            }
            else if(d1>d2 && m1==m2 && y1 == y2)
            {
                hackos = (d1 - d2) * 15;
            } 
            else if(m1>m2 && y1 == y2)
            {
                hackos = (m1-m2)*500;
            }
            else if (y1 > y2)
            {
                hackos = (y1-y2)*10000;
            }

            return hackos;
        }
    }
}
