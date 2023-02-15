namespace LeetCode.Easy1486
{
    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            int javob = 0;
            for (int i = start; i < start + n * 2; i+= 2)
            {
                javob = javob ^ i;
            }
            return javob;
        }
    }
}
