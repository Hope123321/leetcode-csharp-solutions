// 📁 Week1/Day1/0003-longest-substring-without-repeating.cs
// Leetcode: 3. Longest Substring Without Repeating Characters
// Difficulty: Medium
// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/

// 🧠 Approach:
// Use a sliding window to maintain a substring without duplicates.
// Use a hash set to track characters in the current window.
// Move the left pointer when a duplicate is found.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(min(n, m)) where m is the size of the character set

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int left = 0, maxLength = 0;
        for (int right = 0; right < s.Length; right++) {
            while (set.Contains(s[right])) {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}