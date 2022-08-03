using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ZeroAndOneSamePlace
    {
        public static string Method(string str) //01000110010
        {
            StringBuilder text = new StringBuilder();
            int count = 0;
            string resp = string.Empty;
            string resp2 = string.Empty;
            for (int i = 0; i < str.Length; i++)
            { 
                if(str[i] =='0')
                {
                    resp += str[i];
                   // text.Append(str[i]); 
                    continue;
                }
                else
                {
                    resp2 += 1;
                }
            }
            //for (int i = 1; i <= count; i++)
            //{
            //    resp += 1;
            //    //text.Append(1);
            //}
            return resp + resp2;
        }
    }
}
