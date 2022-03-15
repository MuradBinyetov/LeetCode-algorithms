using Creatio.Models;
using Creatio.Models.Easy;
using Creatio.Models.Medium;
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

            #region Easy Tasks

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


            int[] nums7 = { 3, 0, 1 };
            MissingNumber.MissingNumberMethod(nums7);                                           //23


            int[] nums8 = { 0, 1, 0, 3, 12 };
            MoveZeroes.MoveZeroesMethod(nums8);                                                 //24


            WordPattern.WordPatternMethod("abbb", "dog cat cat dog");                           //25


            CountingBits.CountBits(5);                                                          //26


            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString.ReverseStringMethod(s);                                               //27



            ReverseVowelsOfString.ReverseVowels("leetcode");                                    //28



            int[] nums9 = { 1, 2, 2, 1 };
            int[] nums10 = { 2, 2 };
            IntersectionOfTwoArrays.Intersection(nums9, nums10);                                //29


            RansomNote.CanConstruct("aa", "ab");                                                //30


            FirstUniqueCharacterInString.FirstUniqChar("aabb");                                 //31


            IsSubsequence.IsSubsequenceMethod("abc", "ahbgdc");                                 //32


            ConvertNumberHexadecimal.ToHex(-1);                                                 //33


            LongestPalindrome.LongestPalindromeMethod("bb");                                    //34


            FizzBuzz.FizzBuzzMethod(5);                                                         //35


            int[] arr = { 1, 2, 2, 5, 3, 5 };
            ThirdMaximumNumber.ThirdMax(arr);                                                   //36


            AddStrings.AddStringsMethod("34s2", "25");                                          //37


            NumberSegmentsString.CountSegments("world,   ");                                    //38


            ArrangingCoins.ArrangeCoins(8);                                                     //39

            int[] arr1 = { 2, 2 };
            FindAllNumbersDisappearedArray.FindDisappearedNumbers(arr1);                        //40



            int[] g = { 1, 2, 3 }, f = { 1, 1 };
            AssignCookies.FindContentChildren(g, f);                                            //41


            RepeatedSubstringPattern.RepeatedSubstringPatternMethod("abaababaab");              //42


            HammingDistance.HammingDistanceMethod(1, 4);                                        //43


            NumberComplement.FindComplement(1);                                                 //44


            ConstructRectangle.ConstructRectangleMethod(24);                                    //45


            Base7.ConvertToBase7(-8);                                                           //46


            FibonacciNumber.Fib(5);                                                             //47


            DetectCapital.DetectCapitalUse("Usa");                                              //48


            StudentAttendanceRecord1.CheckRecord("PPALLL");                                     //49


            ReverseWordsStringIII.ReverseWords("Let's take LeetCode contest");                  //50


            int[] candyType = { 1, 1, 2, 2, 3, 3 };
            DistributeCandies.DistributeCandiesMethod(candyType);                               //51



            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "KFC", "Shogun", "Burger King" };
            MinimumIndexSumTwoLists.FindRestaurant(list1, list2);                               //52



            int[] flower = { 1, 0, 1, 0, 0, 1 };
            CanPlaceFlowers.CanPlaceFlowersMethod(flower, 2);                                   //53



            int[] numsArr = { 1, 12, -5, -6, 50, 3 };
            int k = 4;
            MaximumAverageSubarray1.FindMaxAverage(numsArr, k);                                 //54


            int[] array = { 3, 2, 2 };
            SetMismatch.FindErrorNums(array);                                                   //55


            RobotReturnOrigin.JudgeCircle("UD");                                                //56


            int[] array2 = { 1, 3, 5, 4, 7 };
            LongestContinuousIncreasingSubsequence.FindLengthOfLCIS(array2);                    //57


            ValidPalindrome2.ValidPalindrome("abca");                                           //58


            BinaryNumberAlternatingBits.HasAlternatingBits(5);                                  //59


            CountBinarySubstrings.CountBinarySubstringsMethod("00110011");                      //60


            int[] array3 = { 1, 2, 2, 3, 1, 4, 2 };
            DegreeArray.FindShortestSubArray(array3);                                           //61


            SelfDividingNumbers.SelfDividingNumbersMethod(1, 22);                                //62



            char[] letters = { 'c', 'f', 'j' };

            FindSmallestLetterGreaterThanTarget.NextGreatestLetter(letters, 'j');               //63


            int[] ar = { 1, 0 };
            LargestNumberLeastTwiceOthers.DominantIndex(ar);                                    //64



            string licenseWord = "1s3 PSt";
            string[] words = { "sttepss", "steps", "stripe", "stepple" };
            ShortestCompletingWord.ShortestCompletingWordMethod(licenseWord, words);            //65


            PrimeNumberSetBitsBinaryRepresentation.CountPrimeSetBits(10, 15);                   //66


            RotateString.RotateStringMethod("abcde", "cdeab");                                  //67


            string paragraph = "L, P! T; p's; q'";
            string[] banned = { "m", "i" };
            MostCommonWord.MostCommonWordMethod(paragraph, banned);                             //68


            PositionsLargeGroups.LargeGroupPositions("aaa");                                    //69


            BackspaceStringCompare.BackspaceCompare("j##xfix", "j###xfix");                     //70


            int[] bills = { 5, 5, 5, 20 };
            LemonadeChange.LemonadeChangeMethod(bills);                                         //71


            BinaryGap.BinaryGapMethod(22);                                                      //72


            ReverseOnlyLetters.ReverseOnlyLettersMethod("Test1ng-Leet=code-Q!");                //73


            int[] sortArr = { 4, 2, 5, 7 };
            SortArrayParityII.SortArrayByParityII(sortArr);                                     //74


            LongPressedName.IsLongPressedName("saeed", "ssaaedd");                              //75 


            int[] sortArr2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            RemoveDuplicatesFromSortedArray.RemoveDuplicates(sortArr2);                         //76

            int[] arr2 = { 3, 2, 2, 3 };
            RemoveElement.RemoveElementMethod(arr2, 3);                                         //77

            ClimbingStairs.ClimbStairs(4);                                                      //78

            Factorial.FactorialMethod(5);                                                       //79

            int[] arr3 = { 3, 7, 5, 10, 8, 12, 14, 11 };
            SortList.SortListMethod(arr3);                                                      //80


            int[] arr4 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            MaximumSubarray.MaxSubArray(arr4);                                                  //81


            int[] prices = { 7, 1, 5, 3, 6, 4 };
            BestTimeToBuySellStock.MaxProfit(prices);                                           //82


            NumberOf1Bits.HammingWeight(00000000000000000000000000001011);


            StrangeAdvertising_HACKERRANK_.viralAdvertising(5);


            int[] c = { 1 ,1 ,1, 0, 1, 1, 0, 0, 0, 0 };
            JumpingCloudsRevisited_HACKKERANK_.jumpingOnClouds(c, 3);

            FindDigits_HACKERRANK_.findDigits(1024);


            List<int> list = new List<int> { 1, 2, 3, 4, 3 ,3 ,2, 1 };
            CutSticks_HACKERRANK_.cutTheSticks(list);

            string[] emails = { "test.email+alex@leetcode.com", "test.email@leetcode.com"};
            UniqueEmailAddresses.NumUniqueEmailsMethod(emails);
            #endregion


            #region Medium Tasks

            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb");

            ReverseInteger.Reverse(123);

            StringToInteger_atoi_.MyAtoi("   -42");

            IntegerToRoman.IntToRoman(58);


            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            ContainerWithMostWater.MaxArea(height);


            int[] n = { -1, 0, 1, 2, -1, -4 };
            _3Sum.ThreeSum(n);

            int[] jumpArr = { 1, 1, 1, 1 };
            JumpGameII.Jump(jumpArr);


            int[] numsArr2 = {-1, 2, 1, -4};
            _3SumCLosest.ThreeSumClosest(numsArr2, 1);


            List<int> a = new List<int> { 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66 };
            PickingNumbers_HACKERRANK_.pickingNumbers(a);


            UtopianTree_HACKERRANK_.utopianTree(5);

            BeatifulDays_HACKERRANK_.beautifulDays(20, 23, 6);

         

            #endregion


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
