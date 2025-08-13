// 📁 Day7/0416-partition-equal-subset-sum.cs
// Leetcode: 416. Partition Equal Subset Sum
// Difficulty: Medium
// Link: https://leetcode.com/problems/partition-equal-subset-sum/

// 🧠 Approach:+
// 1. Calculate the total sum of the array.
// 2. If the total sum is odd, return false.
// 3. Use dynamic programming to check if a subset with sum equal to half of the total sum exists.
// 4. Create a boolean array dp where dp[i] indicates if a subset with sum i can be formed.
// 5. Initialize dp[0] to true (sum of 0 can always be formed).
// 6. Iterate through each number in the array and update the dp array.

// ⏱ Time Complexity: O(n * target)
// 🧠 Space Complexity: O(target)

public class Solution {
    public bool CanPartition(int[] nums) {
        int sum=0;
        foreach(int num in nums){sum+=num;}
        
        if(sum%2!=0) return false;
        
        // Target is half of the total sum
        int target=sum/2;
        bool[] dp=new bool[target+1];
        Array.Fill(dp,false);
        dp[0]=true;
        
        // Dynamic Programming to check for subset sum
        // dp[i] will be true if a subset with sum i can be formed
        foreach(int num in nums){
            for(int i=target;i>=num;i--){
                dp[i]=dp[i]||dp[i-num];
            }
        }
        return dp[target];
    }
}