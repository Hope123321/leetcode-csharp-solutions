// 📁 Week1/Day1/0217-contains-duplicate.cs
// Leetcode: 217. Contains Duplicate
// Difficulty: Easy
// Link: https://leetcode.com/problems/contains-duplicate/

// 🧠 Approach:
// Use a HashSet to filter duplicate number.
// If an Hashset's length not equal nums's length, return true.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(n)

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       return new HashSet<int>(nums).Count < nums.Length;  
    }
}
