namespace LeetCode.Easy136
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
                nums[i] ^= nums[i - 1];

            return nums[nums.Length - 1];
        }
    }
    /*public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);

            for(int i = 0; i < nums.Length - 1; i+= 2)
            {
                if(nums[i] !=  nums[i+1])
                    return nums[i];
            }
            return nums[nums.Length - 1];
        }
    }*/
}
