namespace LeetCode258//solved
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            if (num >= 10)
                return AddDigits(num / 10 + num % 10);
            return num;
        }
    }
}
