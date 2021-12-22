using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FizzBuzz
    {
        public static IList<string> FizzBuzzMethod(int n)
        {
            IList<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    list.Add("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
