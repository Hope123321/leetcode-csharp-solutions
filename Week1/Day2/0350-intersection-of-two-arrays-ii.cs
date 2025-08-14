// 📁 Day2/0350-intersection-of-two-arrays-ii.cs
// Leetcode: 350. Intersection of Two Arrays II
// Difficulty: Easy
// Link: https://leetcode.com/problems/intersection-of-two-arrays-ii/

// 🧠 Approach:
// Use a dictionary to count the frequency of elements in the first array.
// Then iterate through the second array and collect elements that appear in both arrays.
// Decrease the count to handle duplicates properly.
//
// ⏱ Time Complexity: O(n + m) where n = nums1.Length, m = nums2.Length
// 🧠 Space Complexity: O(min(n, m)) for the hash map (assuming best-case size optimization)

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> feq=new Dictionary<int,int>();
        List<int> ret=new List<int>();
        
		foreach(int num in nums1){
			if(feq.ContainsKey(num))
				feq[num]++;
            else
			    feq.Add(num,1);
		}
		foreach(int num in nums2){
			if(feq.ContainsKey(num)&& feq[num]>0){
				feq[num]--;
				ret.Add(num);
				}
		}
		return ret.ToArray();
    }
}