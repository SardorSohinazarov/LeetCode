namespace LeetCode507//solved
{
    public class Solution
    {
        public bool CheckPerfectNumber(int num)
        {
            var set = new HashSet<int>() { 6, 28, 496, 8128, 33550336 };
            return set.Contains(num);
        }
    }
    /*public class Solution
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 1) return false;
            int s = 0;
            for (int i = 1; i < num / 2 + 1; i++)
                if (num % i == 0)
                    s += i;
            return s == num;
        }
    }*/
}
