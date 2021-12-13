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
            Console.WriteLine(Polindrome.IsPolindrome(151));
            Console.WriteLine(RomanTime.RomanToInt("MCMXCIV"));

            string str = "flight";
            Console.WriteLine("substringb:{0}", str.Substring(0, 2));

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
