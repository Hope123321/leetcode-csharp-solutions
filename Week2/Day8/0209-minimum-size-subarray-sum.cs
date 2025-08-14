// 📁 Day8/0209-minimum-size-subarray-sum.cs
// Leetcode: 209. Minimum Size Subarray Sum
// Difficulty: Medium
// Link: https://leetcode.com/problems/minimum-size-subarray-sum/

// 🧠 Approach:
//	1. Use a sliding window technique to find the minimum length of a contiguous subarray whose sum is at least `target`.
//	2. Initialize two pointers `l` and `r` to represent the left and right ends of the window.
//	3. Expand the right pointer `r` to include elements in the window and accumulate their sum.
//	4. If the sum of the current window is greater than or equal to `target`, update the minimum length and move the left pointer `l` to reduce the window size.
//	5. Continue this process until the right pointer reaches the end of the array.
//	6. If no valid subarray is found, return 0.

// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)  

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
         int len=nums.Length;
		if(len==1) return nums[0]>target?1:0;
		
		int r=0;
		int l=0;
		int sum=0;
		int minLen=int.MaxValue;
		
		while(r<len){
			sum+=nums[r];
			while(sum>=target){
				minLen=Math.Min(r-l+1,minLen);
				sum-=nums[l];
				l++;
			}
			r++;
		}
		return minLen !=int.MaxValue?minLen:0;
    }
}