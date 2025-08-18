// 📁 Day11/0560-subarray-sum-equals-k.cs
// Leetcode: 560. Subarray Sum Equals K 
// Difficulty: Medium
// Link: https://leetcode.com/problems/subarray-sum-equals-k/

// 🧠 Approach:
// 使用前綴和的方式來計算子陣列的和，
// 利用哈希表來記錄前綴和出現的次數，
// 當前綴和減去 k 的值存在於哈希表中時，則表示有一個子陣列的和等於 k。

// ⏱ Time Complexity: O(n) because we traverse the array once, where n is the length of the input array.
// 🧠 Space Complexity: O(n) use calculate space on the Hash Table

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        int sum = 0;
        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
        prefixSumCount[0] = 1; // Initialize with sum 0

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];

            // Check if there is a prefix sum that matches the current sum - k
            if (prefixSumCount.ContainsKey(sum - k)) {
                count += prefixSumCount[sum - k];
            }

            // Update the count of the current prefix sum
            if (prefixSumCount.ContainsKey(sum)) {
                prefixSumCount[sum]++;
            } else {
                prefixSumCount[sum] = 1;
            }
        }

        return count;
        
    }
}