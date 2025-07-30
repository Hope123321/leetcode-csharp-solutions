// 📁 Week1/Day1/0242-valid-anagram.cs
// Leetcode: 242. Valid Anagram
// Difficulty: Easy
// Link: https://leetcode.com/problems/valid-anagram/

// 🧠 Approach:
// Use a fixed-size array to count character frequencies.
// Increment for string s and decrement for string t.
// If all values are zero, the strings are anagrams.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1) (assuming only 26 lowercase English letters)

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        return count.All(c => c == 0);
    }
}