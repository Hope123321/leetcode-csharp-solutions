// 📁 Day14/0368-largest-divisible-subset.cs
// Leetcode: 368. Largest Divisible Subset 
// Difficulty: Medium
// Link: https://leetcode.com/problems/largest-divisible-subset/

// 🧠 Approach:
// The problem can be solved using dynamic programming.
// We can maintain a dp array where dp[i] represents the size of the largest divisible subset that ends with nums[i].
// We also maintain a prev array to reconstruct the subset later.
// We iterate through the sorted array and for each element, we check all previous elements to see if they can form a divisible subset with the current element.
// If nums[i] is divisible by nums[j], we can update dp[i] and prev[i] accordingly.
// After filling the dp and prev arrays, we find the maximum value in dp to get the size of the largest divisible subset.


// ⏱ Time Complexity: // O(n^2) where n is the length of the input array nums. 
// 🧠 Space Complexity: // O(n) for the dp and prev arrays

public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        if (nums == null || nums.Length == 0) return new List<int>();

        Array.Sort(nums);
        int n = nums.Length;
        int[] dp = new int[n];
        int[] prev = new int[n];
        int maxSize = 0, maxIndex = -1;

        for (int i = 0; i < n; i++) {
            dp[i] = 1; // Each number is a subset of size 1
            prev[i] = -1; // No previous element initially

            for (int j = 0; j < i; j++) {
                if (nums[i] % nums[j] == 0 && dp[i] < dp[j] + 1) {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }

            if (dp[i] > maxSize) {
                maxSize = dp[i];
                maxIndex = i;
            }
        }

        IList<int> result = new List<int>();
        while (maxIndex != -1) {
            result.Add(nums[maxIndex]);
            maxIndex = prev[maxIndex];
        }

        result.Reverse(); // Reverse to get the correct order
        return result;
    }
}