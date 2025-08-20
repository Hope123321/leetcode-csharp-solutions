// 📁 Day13/0279-perfect-squares.cs
// Leetcode: 279. Perfect Squares
// Difficulty: Medium
// Link: https://leetcode.com/problems/perfect-squares/

// 🧠 Approach:
// The problem can be solved using dynamic programming.
// We can define a dp array where dp[i] represents the minimum number of perfect square numbers that sum to i.
// We initialize dp[0] to 0 and for each number from 1 to n, we check all perfect squares less than or equal to that number.
// For each perfect square, we update the dp array by taking the minimum of the current value and the value at dp[i - j*j] + 1, where j*j is the perfect square.
// This way, we build up the solution for each number from 1 to n using previously computed values in the dp array.

// ⏱ Time Complexity: O(n * sqrt(n)), where n is the input number. This is because we iterate through all numbers from 1 to n, and for each number, we check all perfect squares up to that number.
// 🧠 Space Complexity: O(n)

public class Solution {
    public int NumSquares(int n) {
        if (n < 0) return 0;
        if (n == 0) return 0;
        
        int[] dp = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            dp[i] = int.MaxValue;
            for (int j = 1; j * j <= i; j++) {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }
        
        return dp[n];
    }
}