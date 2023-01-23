namespace LeetCode204;

public class Solution
{
    public int CountPrimes(int n)
    {
        int count = 0;
        if (n < 3)
            count++;

        for (int i = 3; i < n; i += 2)
        {
            if(IsPrimary(i))
                count++;
        }


        return count;
    }
    public bool IsPrimary(int n)
    {
        int i, m = 0, flag = 0;
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                flag = 1;
                return false;
                break;
            }
        }
        if (flag == 0)
            return true;
        return false;
    }
}
