using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string[] arr = new string[] { "flower", "flow", "flight" };
            for (int i = 0; i < arr.Length; i++) //array
            { 
                for (int f = 0; f < arr[i].Length; f++) //soz
                {
                   
                } 
            }
           
            return "";
        }



        private static string GetLongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            var min = int.MaxValue;
            foreach (var item in strs)
            {
                if (item.Length < min)
                {
                    min = item.Length;
                }
            }

             string[] arr = new string[] { "flower", "flow", "flight" };
            var index = -1;  // 0   1   
            for (int i = 0; i < min; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[0][i] != strs[j][i])   // f  f  f      fl  fl
                    {
                        return strs[0].Substring(0, i);
                    }
                    else
                    {
                        index = i;  // 0    1   2
                    }
                }
            }
            return strs[0].Substring(0, index + 1);
        }
    }
}
