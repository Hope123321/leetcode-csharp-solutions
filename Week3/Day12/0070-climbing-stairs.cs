// 📁 Day12/0070-climbing-stairs.cs
// Leetcode: 70. Climbing Stairs
// Difficulty: Easy
// Link: https://leetcode.com/problems/climbing-stairs/

// 🧠 Approach:
// The problem can be solved using dynamic programming.
// We can define a recurrence relation where the number of ways to reach step n is the sum of the ways to reach steps n-1 and n-2.
// We can use two variables to keep track of the last two computed values, which allows us to compute the current value in constant space.


// ⏱ Time Complexity: O(n) depending on the number of steps n.
// 🧠 Space Complexity: O(1) since we are using only a constant amount of space for the last two computed values.

public class Solution {
    public int ClimbStairs(int n) {
        if(n==1 || n==2)return n;
		
		int lastValue=1;
		int nowValue=2;
		int result=0;
		
		for(int i=2;i<n;i++){
			result=lastValue+nowValue;
			lastValue=nowValue;
			nowValue=result;
		}
		return result;
    }
}