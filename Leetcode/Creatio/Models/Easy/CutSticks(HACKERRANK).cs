using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class CutSticks_HACKERRANK_
    {
        public static List<int> cutTheSticks(List<int> arr) //1 2 3 4 3 3 2 1   --> 1 1 2 2 3 3 3 4
        {
            List<int> respList = new List<int>(); 
            arr.Sort(); 
            while (arr.Count > 0)
            {
                respList.Add(arr.Count);

                int min = arr[0];
                arr.RemoveAll(a => a == min);
                for (int i = 0; i < arr.Count; i++)
                {  
                    arr[i] -= min; 
                } 
            } 
            return respList;
        }
    }
}
