namespace LeetCode.Easy//solved
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = sum + nums[i];
                sum = nums[i];
            }
            return nums;
        }
    }
}
