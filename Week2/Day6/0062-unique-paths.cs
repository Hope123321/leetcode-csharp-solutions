// 📁 Day6/0062-unique-paths.cs
// Leetcode: 62. Unique Paths
// Difficulty: Medium
// Link: https://leetcode.com/problems/unique-paths/

// 🧠 Approach:
// Use dynamic programming to count the number of paths to each cell.
// The robot can only move down or right, so paths[i][j] = paths[i-1][j] + paths[i][j-1].
// Initialize the first row and column to 1 because there's only one way to reach them.
//
// ⏱ Time Complexity: O(m * n)
// 🧠 Space Complexity: O(m * n) (can be optimized to O(n))

public class Solution {
    public int UniquePaths(int m, int n) {
        // Create a 2D array to store the number of unique paths to each cell
        int[,] dp = new int[m, n];

        // Initialize the first row and first column
        for (int i = 0; i < m; i++) {
            dp[i, 0] = 1; // Only one way to reach any cell in the first column
        }
        for (int j = 0; j < n; j++) {
            dp[0, j] = 1; // Only one way to reach any cell in the first row
        }

        // Fill the rest of the dp array
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1]; // Sum of paths from top and left cells
            }
        }

        // The bottom-right cell contains the total number of unique paths
        return dp[m - 1, n - 1];
    }
}