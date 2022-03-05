using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class NumberSegmentsString
    {
        public static int CountSegments(string s)
        {
            List<string> list = new List<string>(s.Split(' '));
            
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == "")
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

 
            return list.Count;
        }
    }
}
