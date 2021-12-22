using Creatio.Models;
using Creatio.Models.Easy;
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
            Console.WriteLine(Polindrome.IsPolindrome(151));                                    //1

            Console.WriteLine(RomanTime.RomanToInt("MCMXCIV"));                                 //2

            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestPrefix.GetLongestCommonPrefix(strs));                      //3

            Console.WriteLine(ValidParentheses.IsValid("{[]}"));                                //4

            ListNode l11 = new ListNode(1);
            ListNode l12 = new ListNode(3);
            MergeTwoSortedLists.MergeTwoLists(l11, l12);                                        //5

            Console.WriteLine("index nomre:{0}", ImplementStr.StrStr("aa", "bba"));             //6

            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            Console.WriteLine(SearchInsertPosition.SearchInsert(nums, target));                 //7


            Console.WriteLine(LengthOfTheWord.LengthOfLastWord("Today is a nice day   "));      //8

            int[] nums2 = { 9, 9 };
            PlusOne.PlusOneMethod(nums2);                                                       //9

            int[] nums3 = { 4, 1, 2, 1, 2 };
            SingleNumber.SingleNumberMethod(nums3);                                             //10


            ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama");                     //11

            PascalTriangle.Generate(4);                                                         //12

            PascalTriangle2.GetRow(3);                                                          //13

            int[] nums4 = { 2, 7, 11, 15 };
            TwoSum.TwoSumMethod(nums4, 9);                                                      //14

            int[] nums5 = { 6, 5, 5 };
            MajorityElement.MajorityElementMethod(nums5);                                       //15


            HappyNumber.IsHappy(133);                                                           //16


            IsomorphicStrings.IsIsomorphic("badc", "baba");                                     //17


            int[] nums6 = { 0, 2, 3, 4, 6, 8, 9 };
            SummaryRangers.SummaryRanges(nums6);                                                //18


            PowerOfTwo.IsPowerOfTwo(0);                                                         //19



            ValidAnagram.IsAnagram("aacc", "ccac");                                             //20


            AddDigits.AddDigitsMethod(38);                                                      //21


            UglyNumber.IsUgly(-2147483648);                                                     //22

            
            int[] nums7 = {3,0,1};
            MissingNumber.MissingNumberMethod(nums7);                                           //23


            int[] nums8 = { 0, 1, 0, 3, 12 };
            MoveZeroes.MoveZeroesMethod(nums8);                                                 //24


            WordPattern.WordPatternMethod("abbb","dog cat cat dog");                            //25


            CountingBits.CountBits(5);                                                          //26


            char[] s = { 'h', 'e', 'l', 'l', 'o'};
            ReverseString.ReverseStringMethod(s);                                               //27



            ReverseVowelsOfString.ReverseVowels("leetcode");                                    //28



            int[] nums9 = { 1,2,2,1 };
            int[] nums10 = { 2,2 };
            IntersectionOfTwoArrays.Intersection(nums9,nums10);                                 //29


            RansomNote.CanConstruct("aa", "ab");                                                //30


            FirstUniqueCharacterInString.FirstUniqChar("aabb");                                 //31


            IsSubsequence.IsSubsequenceMethod("abc", "ahbgdc");                                 //32

 
            ConvertNumberHexadecimal.ToHex(-1);                                                 //33


            LongestPalindrome.LongestPalindromeMethod("bb");                                    //34


            FizzBuzz.FizzBuzzMethod(5);                                                         //35


            int[] arr = { 1,2,2,5,3,5 };
            ThirdMaximumNumber.ThirdMax(arr);

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
