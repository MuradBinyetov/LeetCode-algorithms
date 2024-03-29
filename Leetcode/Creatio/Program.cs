﻿using Creatio.Models;
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
            int[] nums = { 1, 2, 3 };
            int[] nums2 = { 2, 5, 6 };
            MergeSortedArray.Merge(nums,3,nums2,3);

            #region Easy Tasks 
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 9, 8, 9 } };
            SumOfDiagonalTwoDimensionalArray.ArrayDiagonal(array);

            int[] arr = { 5, 18, 2, 21, 7, 1 };
            TwoMinIntegersFromArray.MaxMethod(arr);

            int[] arr2 = {1,1,0,0,1,1,0,0,1};
            ZeroAndOneSamePlace.Method2(arr2);
             

            #endregion


            #region Medium Tasks

            //LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb");

            //ReverseInteger.Reverse(123);

            //StringToInteger_atoi_.MyAtoi("   -42");

            //IntegerToRoman.IntToRoman(58);


            //int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //ContainerWithMostWater.MaxArea(height);


            //int[] n = { -1, 0, 1, 2, -1, -4 };
            //_3Sum.ThreeSum(n);

            //int[] jumpArr = { 1, 1, 1, 1 };
            //JumpGameII.Jump(jumpArr);


            //int[] numsArr2 = {-1, 2, 1, -4};
            //_3SumCLosest.ThreeSumClosest(numsArr2, 1);


            //List<int> a = new List<int> { 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66 };
            //PickingNumbers_HACKERRANK_.pickingNumbers(a);


            //UtopianTree_HACKERRANK_.utopianTree(5);

            //BeatifulDays_HACKERRANK_.beautifulDays(20, 23, 6);



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
