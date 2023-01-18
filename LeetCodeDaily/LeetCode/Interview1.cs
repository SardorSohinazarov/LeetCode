using System.Transactions;
using System;
using System.Globalization;

namespace LeetCodeIterview
{
    public class Interview1
    {
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.

        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

    }
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;  
            List<int> ints = prices.ToList();

            for (int i = 0; i< prices.Length; i++)
            {
                if( ints.Max()-prices[i] > maxProfit)
                    maxProfit = ints.Max() - prices[i];
                ints.Remove(prices[i]);
            }

            return maxProfit;
        }
    }
}
