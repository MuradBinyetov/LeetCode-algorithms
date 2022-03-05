using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class JumpingCloudsRevisited_HACKKERANK_
    {
        public static int jumpingOnClouds(int[] c, int k) // int[] c = { 1 1 1 0 1 1 0 0 0 0};
        {
            int j = 100, i = 0;
            do
            {
                j -= (c[i] == 1) ? 3 : 1;
                i = (i + k) % c.Length;
            } while (i != 0);
             return j;
        }
    }
}
