// 📁 Day5/0122-best-time-to-buy-and-sell-stock-ii.cs
// Leetcode: 122. Best Time to Buy and Sell Stock II
// Category: Array, Greedy
// Difficulty: Medium
// Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/

// 🧠 Approach:
// 透過Greedy方式，在每次價格上漲時買入並賣出，累積所有的利潤。
// 這樣可以確保在每次價格上漲時都能獲得利潤，並且不會錯過任何機會。


// ⏱ Time Complexity: O(n) — 遍歷一次 nums。
// 🧠 Space Complexity: O(1) — 只使用常數空間。

public class Solution {
    public int MaxProfit(int[] prices) {
		    int len=prices.Length;
			if(len<2) return 0;
			
			int maxProfit=0;
			
			for(int i=0;i<len-1;i++){
				if(prices[i]<prices[i+1])
					maxProfit+=prices[i+1]-prices[i];
			}
			return maxProfit;
    }
}