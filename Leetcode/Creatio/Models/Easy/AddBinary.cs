using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class AddBinary
    {
        public static string AddBinaryMethod(string a, string b) //a = "1010", b = "1011"
        {
            //I don't Understand???
            var stack = new Stack<string>();
            var resp = "";

            if(a.Length != b.Length)
            {
                var length = a.Length > b.Length ? a.Length - b.Length : b.Length - a.Length;
                for (int i = 0; i < length; i++)
                {
                    if(a.Length > b.Length)
                    {
                        b = "0" + b;
                    }
                    else
                    {
                        a = "0" + a;
                    }
                }
            }

            if (a.Length == b.Length)
            {
                var reminder = 0;
                for (int i = a.Length-1; i >=0; i--)
                { 
                    var sum =  int.Parse(a[i].ToString()) + int.Parse(b[i].ToString())+reminder;
                    if(sum == 2)
                    {
                        stack.Push("0");
                        reminder = 1;
                    }
                    else if(sum == 3)
                    {
                        stack.Push("1");
                        reminder = 1; 
                    }
                    else
                    {
                        stack.Push(sum.ToString());
                        reminder = 0;
                    }
                }
                if(reminder == 1)
                {
                    stack.Push("1");
                }
            } 

            foreach (var item in stack)
            {
                resp += item;
            }
            return resp;
        }
    }
}
