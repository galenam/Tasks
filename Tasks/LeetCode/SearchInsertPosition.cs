namespace Tasks.LeetCode;

public static class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {
        if (target <= nums[0])
        {
            return 0;
        }

        var last = nums.Length - 1;
        if (target == nums[last])
        {
            return last;
        }

        if (target > nums[last])
        {
            return last + 1;
        }
        var middle = last / 2;
        var first = 0;

        while (first < last)
        {
            if (nums[middle] == target)
            {
                return middle;
            }

            if (last - first == 1 && nums[last] > target && nums[first] < target)
            {
                return last;
            }

            if (nums[middle] < target)
            {
                first = middle;
                middle = (last + middle) / 2;
            }
            else
            {
                last = middle;
                middle /= 2;
            }
        }

        return middle;
    }
}