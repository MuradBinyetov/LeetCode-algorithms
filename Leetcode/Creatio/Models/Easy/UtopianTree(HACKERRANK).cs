using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class UtopianTree_HACKERRANK_
    {
        public static int utopianTree(int n) //5
        {
            bool isSpring = true;
            int height = 1;
            int lastHeight = 1;  

            while (n > 0)
            {  
                if(!isSpring)
                {
                    lastHeight = height;
                    height++;
                    isSpring = true;
                }
                else if (isSpring)
                {
                    lastHeight = height;
                    height = height*2;
                    isSpring = false;
                } 
                n--;
            }

            return height; 
        }
    }
}
