// 📁 Day2/0125-valid-palindrome.cs
// Leetcode: 125. Valid Palindrome
// Difficulty: Easy
// Link: https://leetcode.com/problems/valid-palindrome/

// 🧠 Approach:
// Use two pointers starting from both ends of the string.
// Skip non-alphanumeric characters and compare characters ignoring cases.
// If all matching characters are equal, it's a valid palindrome.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)

public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        while (left < right) {
            while (left < right && !char.IsLetterOrDigit(s[left])) left++;
            while (left < right && !char.IsLetterOrDigit(s[right])) right--;
            if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;
            left++;
            right--;
        }
        return true;
    }
}