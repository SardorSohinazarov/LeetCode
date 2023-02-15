namespace LeetCode.Medium;//solved

public class Solution
{
    public int Reverse(int x)
    {
        long result = 0;

        while (x != 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
        }

        if (result > int.MaxValue || result < int.MinValue)
            return 0;

        return (int)result;
    }
}