namespace LeetCode367
{
    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            long x = num;

            while(x*x > num)
            {
                x = (x + num / x) / 2;
            }

            return x * x == num;
        }
    }

    /* public class Solution
     {
         public bool IsPerfectSquare(int num)
         {
             int i = 1;
             while(num > 0)
             {
                 num -= i;
                 i += 2;
             }

             return num == 0;
         }
     }*/
}
