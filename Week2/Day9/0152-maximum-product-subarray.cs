// 📁 Day9/0152-maximum-product-subarray.cs
// Leetcode: 152. Maximum Product Subarray
// Difficulty: Medium
// Link: https://leetcode.com/problems/maximum-product-subarray/

// 🧠 Approach:
// 使用 Dynamic Programming（動態規劃）
// 設 maxProduct 為當前子陣列的最大乘積，minProduct 為當前子陣列的最小乘積。
// 當遇到負數時，最大乘積和最小乘積會互換，因為負數乘以最小乘積可能會得到更大的最大乘積。
// 初始化 maxProduct、minProduct 和 result 為 nums[0]。
// 循環遍歷 nums，更新 maxProduct 和 minProduct，並更新 result 為當前的最大乘積。


// ⏱ Time Complexity: O(n) — 遍歷一次 nums
// 🧠 Space Complexity: O(1) - 固定變數

public class Solution {
      public int MaxProduct(int[] nums) {
        int maxProduct = nums[0];
        int minProduct = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < 0) (maxProduct,minProduct)=(minProduct,maxProduct);

            maxProduct = Math.Max(nums[i], maxProduct * nums[i]);
            minProduct = Math.Min(nums[i], minProduct * nums[i]);

            result = Math.Max(result, maxProduct);
        }

        return result;
    }
}