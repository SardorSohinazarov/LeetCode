namespace LeetCode.Easy//solved
{
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            return n > 0 && (n & n - 1) == 0 && (n - 1) % 3 == 0;
        }
    }
    /* public class Solution
     {
         public bool IsPowerOfFour(int n)
         {
             if (n == 0) return false;

             while (n % 4 == 0)
             {
                 n /= 4;
             }
             return n == 1;
         }
     }*/
}
