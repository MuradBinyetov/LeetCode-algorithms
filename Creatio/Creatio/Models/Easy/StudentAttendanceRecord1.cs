using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class StudentAttendanceRecord1
    {  
        
        public static bool CheckRecord(string s)
        { 
            int count = 0;
            int countL = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'A')
                {
                    count++;
                }
                if (count >= 2) return false;
                if(s[i] == 'L')
                {
                    countL++;
                }
                else
                {
                    countL = 0;
                }
                if (countL >= 3) return false;
            }
            return true;
        }
    }
}
