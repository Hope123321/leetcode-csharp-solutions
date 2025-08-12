// 📁 Day6/0055-jump-game.cs
// Leetcode: 55. Jump Game
// Difficulty: Medium
// Link: https://leetcode.com/problems/jump-game/

// 🧠 Approach:
// Use a greedy strategy to track the farthest position we can reach.
// Iterate through nums, updating the farthest reachable index.
// If at any point the current index is greater than the farthest reachable index, return false.
// If we can reach or pass the last index, return true.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)

public class Solution {
    public bool CanJump(int[] nums) {
        int farthest = 0;
        for (int i = 0; i < nums.Length; i++) {
            // If the current index is beyond the farthest reachable index, we cannot proceed
            if (i > farthest) {
                return false;
            }
            // Update the farthest reachable index
            farthest = Math.Max(farthest, i + nums[i]);
            // If we can reach or pass the last index, return true
            if (farthest >= nums.Length - 1) {
                return true;
            }
        }
        return false;
    }
}