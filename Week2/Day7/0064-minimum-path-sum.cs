// 📁 Day7/0064-minimum-path-sum.cs
// Leetcode: 64. Minimum Path Sum
// Difficulty: Medium
// Link: https://leetcode.com/problems/minimum-path-sum/

// 🧠 Approach:
// Use dynamic programming to find the minimum path sum from the top-left to the bottom-right corner of a grid.
// Create a 2D array to store the minimum path sums.
// Iterate through the grid, updating the minimum path sum for each cell based on the values from the top and left cells.
// If we are at the first row, we can only come from the left; if we are at the first column, we can only come from above.
// The minimum path sum for each cell is the value of the cell plus the minimum of the path sums from the top and left cells.
// If we reach the bottom-right corner, return the minimum path sum for that cell.
//
// ⏱ Time Complexity: O(m * n) where m is the number of rows and n is the number of columns in the grid.
// 🧠 Space Complexity:   

public class Solution {
   public int MinPathSum(int[][] grid) {
        int m=grid.Length;
		int n=grid[0].Length;
		int[,] dp=new int[m,n];

        // Initialize the first row and first column of the dp array    
		dp[0,0]=1;
		for(int i=1;i<m;i++){
			dp[i,0]=grid[i][0]+dp[i-1,0];
		}
		for(int j=1;j<n;j++){
			dp[0,j]=grid[0][j]+dp[0,j-1];
		}
		
        //fill the minimum path sum for the rest of the grid
		for(int i=1;i<m;i++){
			for(int j=1;j<n;j++){
					dp[i,j]=grid[i][j]+Math.Min(dp[i-1,j],dp[i,j-1]);
			}
		}
		
		return dp[m-1,n-1];
    }
}