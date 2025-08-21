// 📁 Day14/0930-binary-subarrays-with-sum.cs
// Leetcode: 930. Binary Subarrays With Sum 
// Difficulty: Medium
// Link: https://leetcode.com/problems/binary-subarrays-with-sum/

// 🧠 Approach:
// The problem can be solved using a prefix sum approach.
// We maintain a running sum of the elements in the array and use a dictionary to count the occurrences of each prefix sum.
// For each element in the array, we check if there exists a prefix sum that can form a subarray with the required sum (goal).

// ⏱ Time Complexity: // O(n) where n is the length of the input array nums.
// 🧠 Space Complexity: // O(n) for the dictionary to store prefix sums

public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int count = 0;
        int sum = 0;
        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
        prefixSumCount[0] = 1; // To handle the case where the sum equals goal from the start

        for (int num : nums) {
            sum += num;

            // Check if there is a prefix sum that can form the required subarray
            if (prefixSumCount.ContainsKey(sum - goal)) {
                count += prefixSumCount[sum - goal];
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