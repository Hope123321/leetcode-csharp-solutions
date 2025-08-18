// 📁 Day10/0238-product-of-array-except-self.cs
// Leetcode: 238. Product of Array Except Self
// Difficulty: Medium
// Link: https://leetcode.com/problems/product-of-array-except-self/

// 🧠 Approach:
// 使用前綴乘積和後綴乘積的方式來計算每個元素的乘積，
// 不使用除法，並且在 O(n) 的時間內完成。
// 初始化一個結果陣列 result，長度與 nums 相同。
// 首先計算prifix sum，將結果存入 result。
// 然後計算suffix sum，並將其與前綴乘積相乘，得到最終結果。

// ⏱ Time Complexity:  O(n) because of the execution time of loop dpends on the input size of array
// 🧠 Space Complexity: O(1)  by reducing the usage of slice and output array doesn’t count as extra space for space complexity analysis. 

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        result[0] = 1;

        // Calculate prefix products
        for (int i = 1; i < n; i++) {
            result[i] = result[i - 1] * nums[i - 1];
        }

        int suffixProduct = 1;
        // Calculate suffix products and multiply with prefix products
        for (int i = n - 1; i >= 0; i--) {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }

        return result;
    }
}