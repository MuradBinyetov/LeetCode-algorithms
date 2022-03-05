using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BaseballGame
    {
        public static int CalPoints(string[] ops) // ["5","-2", +,"4","C","D","9","+","+"]
        {
            List<int> list = new List<int>(); 

            for (int i = 0; i < ops.Length; i++)
            {
                string o = ops[i];
                if (o == "+")
                {
                    list.Add(list[list.Count-1] +list[list.Count-2]); 
                }
                else if(o == "D")
                {
                    list.Add(list[list.Count - 1] * 2);
                }
                else if (o == "C")
                {
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    list.Add(int.Parse(o));
                }
            }



            return list.Sum();
        }
    }
}
