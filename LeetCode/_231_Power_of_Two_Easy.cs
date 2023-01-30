namespace LeetCode231// solved
{
    //the third approach
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            return n < 1 ? false : (n & (n - 1)) == 0 ? true : false;
        }
    }


    // the second approach
    /*public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            long x = (long)n;
            return (x & (x - 1)) == 0;
        }
    }*/


    //first approach
    /*public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if(n == 0) return false;

            while(n % 2 == 0)
            {
                n /= 2;
            }

            return n == 1;
        }
    }*/
}
