// 📁 Day3/0169-majority-element.cs
// Leetcode: 169. Majority Element
// Difficulty: Easy
// Link: https://leetcode.com/problems/majority-element/

// 🧠 Approach:
// 將陣列排序，因為眾數出現超過一半，所以排完後一定會佔據中間位置。
// 例如長度為 n，則 nums[n/2] 必為眾數。
//
// ⏱ Time Complexity: O(n log n)：排序的時間複雜度。
// 🧠 Space Complexity: O(1)，用原變數排序。

public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
	    return nums[nums.Length/2];
    }
}