// 📁 Day10/0714-best-time-to-buy-and-sell-stock-with-transaction-fee.cs
// Leetcode: 714. Best Time to Buy and Sell Stock with Transaction Fee
// Difficulty: Medium
// Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/

// 🧠 Approach:
// 使用 Dynamic Programming（動態規劃）
// 設 hold 為持有股票的最大利潤，cash 為不持有股票的最大利潤。
// 初始時，持有股票的最大利潤為 -prices[0]，不持有股票的最大利潤為 0。
// 在每次迭代中，更新持有股票的最大利潤和不持有股票的最大利潤。

// ⏱ Time Complexity: O(n) — 遍歷一次 prices。
// 🧠 Space Complexity: O(1)

public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        int len = prices.Length;
        if (len < 2) return 0;

        int hold = -prices[0]; // 持有股票的最大利潤
        int cash = 0; // 不持有股票的最大利潤

        for (int i = 1; i < len; i++) {
            // 更新持有股票的最大利潤
            hold = Math.Max(hold, cash - prices[i]);
            // 更新不持有股票的最大利潤
            cash = Math.Max(cash, hold + prices[i] - fee);
        }

        return cash; // 返回不持有股票時的最大利潤
    }
}