// 📁 Day12/0974-subarray-sum-equals-k.cs
// Leetcode: 974. Subarray Sums Divisible by K
// Difficulty: Medium
// Link: https://leetcode.com/problems/subarray-sums-divisible-by-k/

// 🧠 Approach:
// The problem can be solved using a prefix sum approach with a hash map to count the occurrences of remainders.
// We maintain a running sum and calculate the remainder when divided by k.
// If the same remainder has been seen before, it means there exists a subarray that sums to a multiple of k.
// We use a dictionary to keep track of how many times each remainder has occurred.
// We initialize the dictionary with the remainder 0 to handle cases where the subarray itself is divisible by k.


// ⏱ Time Complexity: O(n) where n is the length of the input array nums.
// 🧠 Space Complexity: O(k) calculate list of size k 

public class Solution {
      public int SubarraysDivByK(int[] nums, int k) {
        int count = 0;
        int sum = 0;
        Dictionary<int, int> remainderCount = new Dictionary<int, int>();
        remainderCount[0] = 1; // To handle the case where the subarray itself is divisible by k

        foreach (int num in nums) {
            sum += num;
            int remainder = ((sum % k) + k) % k; // Ensure non-negative remainder

            // Check if this remainder has been seen before
            if (remainderCount.ContainsKey(remainder)) {
                count += remainderCount[remainder];
                remainderCount[remainder]++;
            }else {
                remainderCount[remainder] = 1;
            }
        }

        return count;
    }
}