// 📁 Day13/0523-continuous-subarray-sum.cs
// Leetcode: 523. Continuous Subarray Sum
// Difficulty: Medium
// Link: https://leetcode.com/problems/continuous-subarray-sum/

// 🧠 Approach:
// The problem can be solved using a hash map to track the remainders of the cumulative sums.
// We maintain a running sum and calculate the remainder when divided by k.
// If the same remainder has been seen before, it means there exists a subarray that sums to a multiple of k.
// We also need to ensure that the length of the subarray is at least 2, so we check the indices of the previous occurrences of the same remainder.


// ⏱ Time Complexity: // O(n) where n is the length of the input array nums.
// 🧠 Space Complexity: // O(k) for the hash map to store remainders

public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if (nums.Length < 2) return false; // Need at least two elements for a subarray

        Dictionary<int, int> remainderMap = new Dictionary<int, int>();
        remainderMap[0] = -1; // Handle the case where the subarray starts from index 0
        int sum = 0;

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            int remainder = sum % k;

            // Adjust negative remainders to be positive
            if (remainder < 0) {
                remainder += k;
            }

            // Check if this remainder has been seen before
            if (remainderMap.ContainsKey(remainder)) {
                // Check if the previous index is at least one index before the current index
                if (i - remainderMap[remainder] > 1) {
                    return true;
                }
            } else {
                // Store the first occurrence of this remainder
                remainderMap[remainder] = i;
            }
        }

        return false;
        
    }
}