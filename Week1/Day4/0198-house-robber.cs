// 📁 Day4/0198-house-robber.cs
// Leetcode: 198. House Robber
// Difficulty: Medium
// Link: https://leetcode.com/problems/house-robber/

// 🧠 Approach:
// 使用 Dynamic Programming（動態規劃）
// dp[i] 表示偷竊到第 i 間房屋的最大金額。
// dp[i] = max(dp[i-1], dp[i-2] + nums[i])，即不偷竊第 i 間房屋或偷竊第 i 間房屋的最大金額。
// 由於只需要前兩個狀態，所以可以使用兩個變數來代替整個 dp 陣列，節省空間。

// ⏱ Time Complexity: O(n) — 遍歷一次 nums。
// 🧠 Space Complexity: O(1) — 只使用常數空間。

public class Solution {
    public int Rob(int[] nums) {
       int len=nums.Length;
		if(len==1) return nums[0];
		
		int lastValue=nums[0];
		int nowValue=Math.Max(nums[0],nums[1]);
		int result=nowValue;
		
		for(int i=2;i<len;i++){
			result=Math.Max(lastValue+nums[i],nowValue);
			lastValue=nowValue;
			nowValue=result;
		}
		return result;
    }
}