using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DeleteColumnsMakeSorted
    {
        public static int MinDeletionSize(string[] strs) //["zyx","wvu","tsr"]
        {
            int cnt = 0;

            for (int j = 0; j < strs[0].Length; j++)
            {
                char prev = strs[0][j];

                for (int i = 1; i < strs.Length; i++)
                {
                    char cur = strs[i][j];

                    if (cur - prev < 0)
                    {
                        cnt++;
                        break;
                    }

                    prev = cur;
                }
            }

            return cnt;
        }
    }
}
