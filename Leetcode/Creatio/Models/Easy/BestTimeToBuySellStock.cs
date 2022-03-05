using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BestTimeToBuySellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[i] > prices[j]) continue;

                   if(prices[j] - prices[i] > max)
                    {
                        max = prices[j] - prices[i];
                    } 
                }
            }

            return max;
        }
    }
}
