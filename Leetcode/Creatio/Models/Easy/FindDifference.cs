using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FindDifference
    {
        public static char FindTheDifference(string s, string t)
        {
            List<char> sList = new List<char>(s);
            List<char> tList = new List<char>(t); 

            for (int i = 0; i < tList.Count; i++)
            { 
                if(sList.Contains(tList[i]))
                {
                    sList.Remove(tList[i]);
                    continue;
                }
                else
                {
                    return tList[i];
                }
            }
            return ' ';
        }
    }
}
