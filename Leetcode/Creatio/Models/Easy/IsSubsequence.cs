using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class IsSubsequence
    {
        public static bool IsSubsequenceMethod(string s, string t)
        {
            if (t.Contains(s)) return true;
            List<char> sList = new List<char>(s);
            List<char> tList = new List<char>(t); 

            for (int i = 0; i < tList.Count; i++)
            {
                if (!sList.Contains(tList[i]))
                {
                    tList.Remove(tList[i]);
                    i--;
                }
                else
                {
                    sList.Remove(tList[i]);
                }
            } 

            string tString = new String(tList.ToArray());
            if (s.Equals(tString)) return true;

            return false;
        }
    }
}
