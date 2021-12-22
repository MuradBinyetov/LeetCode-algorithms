using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FirstUniqueCharacterInString
    {
        public static int FirstUniqChar(string s)
        {
            List<char> list = new List<char>(s);
            List<char> listCopy = new List<char>(s);

            for (int i = 0; i < list.Count; i++)
            {
                listCopy.Remove(list[i]);
                if (listCopy.Contains(list[i]))
                {
                    listCopy.Add(list[i]);
                    continue;
                }
                else
                {
                    return i;
                } 
            }
            return -1;
        }
    }
}
