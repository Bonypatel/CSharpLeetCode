/*
    Given an integer array nums, find the subarray with the largest sum, and return its sum.

    Try to do the sliding window strategy
    Take a new array with moving left and right pointers, check the sum of the two previous array memebers and see if they're positive
    or negative and keep them if its positive.
    Subarray has to be contigous
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        int ans = nums[0];
        int currentSum = 0;
        Console.WriteLine("Lets see how it goes through.");
        foreach (int num in nums)
        {
            if (currentSum < 0)
            {
                currentSum = 0;
            }
            currentSum += num;
            if (currentSum > ans)
            {
                ans = currentSum;
            }
            Console.WriteLine("Current index = {0}.  CurrentSum = {1}.  Max Sum = {2}", num, currentSum, ans);
        }

        return ans;
    }


    static void Main()
    {
        Solution mySolution = new Solution();
        int[] test = [-2,1,-3,4,-1,2,1,-5,4];

        Console.WriteLine(mySolution.MaxSubArray(test));
    }
}