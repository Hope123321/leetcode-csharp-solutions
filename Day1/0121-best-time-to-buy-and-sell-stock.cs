// 📁 Week1/Day1/0121-best-time-to-buy-and-sell-stock.cs
// Leetcode: 121. Best Time to Buy and Sell Stock
// Difficulty: Easy
// Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

// 🧠 Approach:
// Track the minimum price seen so far and calculate the profit for each day.
// Update the minimum when a lower price is found, otherwise calculate profit.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)

public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach (int price in prices) {
            if (price < minPrice) minPrice = price;
            else maxProfit = Math.Max(maxProfit, price - minPrice);
        }
        return maxProfit;
    }
}
