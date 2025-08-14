// 📁 Day5/0300-longest-increasing-subsequence.cs
// Leetcode: 300. Longest Increasing Subsequence
// Category: Dynamic Programming, Binary Search
// Difficulty: Medium
// Link: https://leetcode.com/problems/longest-increasing-subsequence/

// 🧠 Approach:
// 使用 Dynamic Programming（動態規劃）和 Binary Search（二分搜尋）
// dp[i] 表示以 nums[i] 為結尾的最長遞增子序列的長度。
// 我們使用一個 dp 陣列來存儲目前找到的最長遞增子序列的結尾元素。
// 對於每個 nums[i]，我們使用二分搜尋找到 dp 中第一個大於等於 nums[i] 的元素，並更新它。
// 如果 nums[i] 大於 dp 中的所有元素，則將其添加到 dp 的末尾。
// 最終 dp 的長度即為最長遞增子序列的長度。

// ⏱ Time Complexity: O(n log n) — 每個元素都需要進行二分搜尋，總共 n 個元素。
// 🧠 Space Complexity: O(n) — dp 陣列的大小與 nums 相同。

public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums.Length == 0) return 0;

        int[] dp = new int[nums.Length];
        int length = 0;

        foreach (var num in nums) {
            // 使用二分搜尋找到 dp 中第一個大於等於 num 的位置
            int left = 0, right = length;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (dp[mid] < num) {
                    left = mid + 1;
                } else {
                    right = mid;
                }
            }
            // 如果 left 等於 length，表示 num 大於 dp 中的所有元素
            // 否則，更新 dp[left] 為 num
            dp[left] = num;
            if (left == length) length++;
        }

        return length;
        
    }
}