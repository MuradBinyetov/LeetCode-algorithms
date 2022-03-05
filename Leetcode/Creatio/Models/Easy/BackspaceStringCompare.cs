using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string s, string t) //s = "j##xfix", t = "j###xfix";
        {
            string sNewString = CompareString(s);
            string tNewString = CompareString(t);
            if (sNewString.Equals(tNewString))
            {
                return true;
            }
            return false;
        }


        public static string CompareString(string str)
        {
            List<char> sList = new List<char>(str);
            string newString = string.Empty;
            for (int i = 0; i < sList.Count; i++)
            {
                if(sList[0] == '#')
                {
                    sList.RemoveAt(0);
                    i = -1;
                    continue;
                }
                if (sList[i] == '#')
                {
                    sList.RemoveAt(i);
                    sList.RemoveAt(i - 1);
                    i = i - 2;
                }
            }
            foreach (var item in sList)
            {
                newString += item;
            }
            return newString;
        }
    }
}
