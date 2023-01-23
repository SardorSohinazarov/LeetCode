namespace LeetCode204
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            int count = 0;  
            for(int i = 0; i < n; i++)
            {
                if(Prime(i))
                    count++;
            }
            return count;
        }

        public bool Prime(int n)
        {
            if(n == 2)
                return true;

            int count = 0;

            for(int i = 1; i<= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    count ++;
                }
            }

            return count == 1;
        }
    }
}
