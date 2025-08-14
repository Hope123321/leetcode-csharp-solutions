// 📁 Day3/0139-word-break.cs
// Leetcode: 139. Word Break
// Difficulty: Medium
// Link: https://leetcode.com/problems/word-break/

// 🧠 Approach:
// 使用 Dynamic Programming（動態規劃）
// dp[i] 表示 s.Substring(0, i) 是否可以被字典組合出來。
// 如果存在 j 使得 dp[j] 為 true，且 s.Substring(j, i - j) 在字典中，則 dp[i] = true。
//
// ⏱ Time Complexity: O(n^2)
// 🧠 Space Complexity: O(n)

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> wordSet = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;

        for (int i = 1; i <= s.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (dp[j] && wordSet.Contains(s.Substring(j, i - j))) {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[s.Length];
    }
}