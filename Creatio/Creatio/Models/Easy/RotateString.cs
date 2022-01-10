using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class RotateString
    {
        public static bool RotateStringMethod(string s, string goal)
        {
            List<char> list = new List<char>(s);

            string newWord = string.Empty;

            while (!s.Equals(newWord))
            {
                newWord = string.Empty;
                list.Add(list[0]);
                list.Remove(list[0]);
                foreach (var item in list)
                {
                    newWord += item;
                }
                if (goal.Equals(newWord))
                {
                    return true;
                }
            } 
            return false;
        }
    }
}
