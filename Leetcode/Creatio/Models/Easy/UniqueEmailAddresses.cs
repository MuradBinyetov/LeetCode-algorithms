using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class UniqueEmailAddresses
    {
        public static int NumUniqueEmailsMethod(string[] emails) //test.email+alex@leetcode.com" ,"test.e.mail+bob.cathy@leetcode.com"
        {  
            List<String> emailsSet = new List<String>();

            foreach (String e in emails)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < e.Length; i++)
                {
                    if (e[i] == '.')
                    {
                        continue;
                    }
                    else if (e[i] == '+' || e[i] == '@')
                    {
                        int idx = e.Length - 1;
                        while (e[idx] != '@')
                        {
                            idx--;
                        }
                        sb.Append(e.Substring(idx));
                        break;
                    }
                    else
                    {
                        sb.Append(e[i]);
                    } 
                }
                if (!emailsSet.Contains(sb.ToString()))
                {
                    emailsSet.Add(sb.ToString());
                }
                
            } 
            return emailsSet.Count();
        }


    }
}
