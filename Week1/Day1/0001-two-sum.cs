// 📁 Week1/Day1/0001-two-sum.cs
// Leetcode: 1. Two Sum
// Difficulty: Easy
// Link: https://leetcode.com/problems/two-sum/

// 🧠 Approach:
// Use a hash map to store each number's index.
// While iterating, check if (target - current number) exists in the map.
// If it does, return the index of the complement and the current index.
//
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Hashtable table=new Hashtable();

        for(int i=0;i<nums.Length;i++){
            int a=target-nums[i];
           if(!table.ContainsKey(a)){
		   	table[nums[i]]=i;
		   }else{
		   	return new int[2]{Convert.ToInt32(table[a]),i};
		   }
        }
		return new int[0];
    }
}