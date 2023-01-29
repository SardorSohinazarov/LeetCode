namespace LeetCode997//solved
{
    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            if (n == 1)
                return 1;

            int[] urven = new int[n + 1];

            foreach (var t in trust)
            {
                urven[t[0]]--;
                urven[t[1]]++;
            }

            for (int i = 0; i <= n; i++)
                if (urven[i] == n - 1)
                    return i;

            return -1;
        }
    }
}
