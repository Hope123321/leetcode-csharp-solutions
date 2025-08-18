// 📁 Day11/0263-ugly-number.cs
// Leetcode: 264. Ugly Number
// Difficulty: Easy
// Link: https://leetcode.com/problems/ugly-number/

// 🧠 Approach:
// 判斷一個數字是否為丑数，丑数是指只包含質因數 2、3 和 5 的正整數。
// 如果 n 小於等於 0，則返回 false。
// 如果 n 等於 1，則返回 true。

// ⏱ Time Complexity: O(log n) because we are dividing n by 2, 3, or 5 until it becomes 1 or less.

// 🧠 Space Complexity: O(1)

public class Solution {
    public bool IsUgly(int n) {
       	if(n<0)
	   		return false;
		else if(n==1) 
			return true;
		while(n>=2){
			if(n%2==0) n=n/2;
			else if(n%3==0) n=n/3;
			else if(n%5==0) n=n/5;
			else break;
		}
		
		return n==1;
    }
}