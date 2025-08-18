// 📁 Day11/0264-ugly-number-ii.cs
// Leetcode: 264. Ugly Number II
// Difficulty: Medium
// Link: https://leetcode.com/problems/ugly-number-ii/

// 🧠 Approach:
// 使用動態規劃的方式來生成丑数，
// 丑数是指只包含質因數 2、3 和 5 的正整數。
// 我們使用一個陣列來存儲前 n 個丑数，
// 並使用三個指針來跟踪當前的 2、3 和 5 的倍數。
// 當前的最小丑数是這三個指針所指向的數字的最小值，
// 然後更新相應的指針和下一個丑数的值。

// ⏱ Time Complexity: O(n) because we iterate through the array to find the nth ugly number, where n is the input size.
// 🧠 Space Complexity: O(n)

public class Solution {
    public int NthUglyNumber(int n) {
        int[] uglyNumbers = new int[n];
        uglyNumbers[0] = 1; // The first ugly number is 1

        int i2 = 0, i3 = 0, i5 = 0; // Indices for multiples of 2, 3, and 5
        int next2 = 2, next3 = 3, next5 = 5;

        for (int i = 1; i < n; i++) {
            int nextUgly = Math.Min(next2, Math.Min(next3, next5));
            uglyNumbers[i] = nextUgly;

            if (nextUgly == next2) {
                i2++;
                next2 = uglyNumbers[i2] * 2;
            }
            if (nextUgly == next3) {
                i3++;
                next3 = uglyNumbers[i3] * 3;
            }
            if (nextUgly == next5) {
                i5++;
                next5 = uglyNumbers[i5] * 5;
            }
        }

        return uglyNumbers[n - 1];
        
    }
}