using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DegreeArray
    {
        public static int FindShortestSubArray(int[] nums) //[1,2,2,3,1,4,2]  [1,2,2,3,1]
        {
            var dict = new Dictionary<int, int>();
            //get degree of array
            var maxFreq = 0;
            //element repeat that many times
            var max = new List<int>();
            //use dictionary to keep track of frequency
            foreach (var n in nums)
            {
                dict[n] = dict.ContainsKey(n) ? dict[n] + 1 : 1;
                if (dict[n] > maxFreq)
                {
                    maxFreq = dict[n];
                    max = new List<int>() { n };
                    continue;
                }
                if (dict[n] == maxFreq)
                {
                    max.Add(n);
                }
            }
            //figure out all possible subarray length;
            var count = new List<int>();
            foreach (var m in max)
            {
                var tc = 0;
                var found = false;
                var ec = 0;
                foreach (var n in nums)
                {
                    if (!found && n == m)
                    {
                        tc++;
                        found = true;
                        ec++;
                        continue;
                    }
                    if (found && ec < maxFreq)
                    {
                        tc++;
                        if (n == m)
                        {
                            ec++;
                        }
                    }
                }
                count.Add(tc);
            }
            return count.Min();
        }
    }
}
