// 📁 Day8/0213-house-robber-ii.cs
// Leetcode: 213. House Robber II
// Difficulty: Medium
// Link: https://leetcode.com/problems/house-robber-ii/

// 🧠 Approach:
// 1. This problem is similar to the House Robber I problem, but with a circular arrangement of houses.
// 2. We can break the problem into two cases:
//    - Case 1: Rob houses from the first to the second last house (excluding the last house).
//    - Case 2: Rob houses from the second to the last house (excluding the first house).
// 3. For each case, we can use dynamic programming to find the maximum amount of money that can be robbed.
// 4. Finally, we return the maximum of the two cases.

// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)

public class Solution {
    public int Rob(int[] nums) {
        int len=nums.Length;
		if(len==1) return nums[0];
		if(len==2) return Math.Max(nums[0],nums[1]);

        //假設取了第一棟，排除最後一棟
		int lastValue=nums[0];
		int nowValue=Math.Max(nums[0],nums[1]);
		int ret=nowValue;
		for(int i=2;i<len-1;i++){
			ret=Math.Max(lastValue+nums[i],nowValue);
			lastValue=nowValue;
			nowValue=ret;
		}
		
		int lastValueByLast=nums[1];
		int nowValueByLast=Math.Max(nums[1],nums[2]);
		int retByLast=nowValueByLast;
		
		//假設取了最後一棟，排除第一棟
		for(int i=3;i<len;i++){
			retByLast=Math.Max(lastValueByLast+nums[i],nowValueByLast);
			lastValueByLast=nowValueByLast;
			nowValueByLast=retByLast;
		}
		
        //兩者取最大
		return Math.Max(ret,retByLast);
    }
}