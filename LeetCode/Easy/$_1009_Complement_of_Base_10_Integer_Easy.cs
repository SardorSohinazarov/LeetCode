namespace LeetCode1009;//solved

public class Solution
{
    public int BitwiseComplement(int n)
    {
        return n ^ ((1 << Convert.ToString(n, 2).Length) - 1);
    }
}
