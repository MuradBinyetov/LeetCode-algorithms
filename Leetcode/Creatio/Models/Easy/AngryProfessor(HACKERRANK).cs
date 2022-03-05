using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class AngryProfessor_HACKERRANK_
    {
        public static string angryProfessor(int k, List<int> a)
        {
            int arrivedCount = 0;
            int lateCount = 0;
            foreach (var item in a)
            {
                if (item <= 0)
                {
                    arrivedCount++;
                }
                else
                {
                    lateCount++;
                }
            }
            if (arrivedCount >= k)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
