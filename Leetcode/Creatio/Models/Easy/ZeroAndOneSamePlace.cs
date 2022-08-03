using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ZeroAndOneSamePlace
    {
        public static string Method(string str) //01000110010
        {
            StringBuilder text = new StringBuilder();
            int count = 0;
            string resp = string.Empty;
            string resp2 = string.Empty;
            for (int i = 0; i < str.Length; i++)
            { 
                if(str[i] =='0')
                {
                    resp += str[i];
                   // text.Append(str[i]); 
                    continue;
                }
                else
                {
                    resp2 += 1;
                }
            }
            //for (int i = 1; i <= count; i++)
            //{
            //    resp += 1;
            //    //text.Append(1);
            //}
            return resp + resp2;
        }

        public static int[] Method2(int[] arr)//[1,1,0,0,1,1,0,0,1] ->[1,1,1,1,1,0,0,0]
        {
           
            for (int i = 0; i < arr.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                { 
                    if(Compare(minIndex,j,arr) == -1)
                    {
                        minIndex = j; 
                    } 
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

            }
            return arr;
        }

        static int Compare(int index1, int index2,int[] arr) 
        {
            if(arr[index1]>arr[index2])
            {
                return 1;
            }
            else if (arr[index1] < arr[index2])
            {
                return -1;
            }
            return 0;
        }
    }
}
