// 📁 Day4/0704-binary-search.cs
// Leetcode:  704. Binary Search
// Difficulty: Easy
// Link: https://leetcode.com/problems/binary-search/

// 🧠 Approach:
// Use binary search by maintaining left and right pointers to find the target in a sorted array.
// ⏱ Time Complexity: O(log n) — Binary search splits the array each time.
// 🧠 Space Complexity: O(1) — No extra space is used

public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}