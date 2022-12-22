namespace Tasks.LeetCode;

public static class TwoSumCalculate
{
    /*
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.
    Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
     */
    public static int[] TwoSum(int[] nums, int target)
    {
        var storage = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var addition = target - nums[i];
            if (!storage.ContainsKey(addition))
            {
                if (!storage.ContainsKey(nums[i]))
                {
                    storage.Add(nums[i], i); 
                } 
            }
            else
            {
                return new []{storage[addition], i};
            }
        }

        return new[] { -1, -1 };
    }
}