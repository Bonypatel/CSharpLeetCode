/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order. 
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] ans = [0,0];
        int left = 0;
        int right = 1;

        while (right < nums.Length)
        {
            Console.WriteLine("left = {0} and right = {1}", left, right);
            Console.WriteLine("Sum of nums[left] + nums[right] = {0}", nums[left] + nums[right]);
            if ( nums[left] + nums[right] == target)
            {
                ans[0] = left;
                ans[1] = right;
                right = nums.Length;
                Console.WriteLine("It found the target!");
            }
            else if (right == nums.Length - 1)
            {
                left++;
                right = left + 1;
                Console.WriteLine("Right has hit nums.Length, left = {0} and right = {1}", left, right);
            }
            else
            {
                right++;
                Console.WriteLine("Just iterating Right: Right = {0}", right);
            }
        }

        return ans;
    }

    static void Main()
    {
        Solution mySolution = new Solution();
        int[] test = [3,2,4];
        int target = 6;
        int[] solution = mySolution.TwoSum(test, target);
        foreach (int num in solution)
        {
            Console.WriteLine(num);
        }
        
    }
}