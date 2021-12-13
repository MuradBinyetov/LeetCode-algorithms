using Creatio.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine(Polindrome.IsPolindrome(151));                    //1

            Console.WriteLine(RomanTime.RomanToInt("MCMXCIV"));                 //2

            string[] strs = { "flower", "flow", "flight" }; 
            Console.WriteLine(LongestPrefix.GetLongestCommonPrefix(strs));      //3

            Console.WriteLine(ValidParentheses.IsValid("{[]}"));                //4

            ListNode l11 = new ListNode(1);
            ListNode l12 = new ListNode(3); 
            MergeTwoSortedLists.MergeTwoLists(l11, l12);                        //5
            

            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
