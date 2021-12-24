using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class AddStrings
    {
        public static string AddStringsMethod(string num1, string num2)
        {
            int num1Parse;
            bool isParseNum1 = int.TryParse(num1, out num1Parse);

            int num2Parse;
            bool isParseNum2 = int.TryParse(num2, out num2Parse);

            string resp = "";
            if(isParseNum1 && isParseNum2)
            {
                resp = (num1Parse + num2Parse).ToString();
                return resp;
            }

            return "0";
        }
    }
}
