using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FindTownJudge
    {
        public static int FindJudge(int n, int[][] trust) //[ [1,3], [2,3], [3,1] ]
        {
            int response = trust[0][1];

            for (int i = 1; i < trust.Length; i++)
            {
                if(trust[i][1] == response)
                {
                    continue;
                }
                else
                {
                    response = -1;
                }
            }
            return response;
        }
    }
}
