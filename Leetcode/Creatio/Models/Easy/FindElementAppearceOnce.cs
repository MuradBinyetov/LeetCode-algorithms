using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FindElementAppearceOnce
    {
        public static int Method(int[] arr) //{ 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 }
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length-1; i++)
            {
                int count = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], count);
                } 
            }

            int resp = dict.FirstOrDefault(d => d.Value == 1).Key;

            return resp;
        }
    }
}
