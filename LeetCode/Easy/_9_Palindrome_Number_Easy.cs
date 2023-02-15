namespace LeetCode9 // solved
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            long son = x;
            long javob = 0;
            while (son > 0)
            {
                javob = javob * 10 + son % 10;
                son /= 10;
            }
            return javob == x;
        }
    }
}
