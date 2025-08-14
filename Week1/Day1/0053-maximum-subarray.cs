// 📁 Week1/Day1/0053-maximum-subarray.cs
// Leetcode: 53. Maximum Subarray
// Difficulty: Easy
// Link: https://leetcode.com/problems/maximum-subarray/

// 🧠 Approach:
// Use Kadane’s Algorithm.
// At each index, decide whether to start a new subarray or extend the previous one.
// Track the maximum sum seen so far.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSoFar = nums[0];
        int currentMax = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            currentMax = Math.Max(nums[i], currentMax + nums[i]);
            maxSoFar = Math.Max(maxSoFar, currentMax);
        }
        return maxSoFar;
    }
}