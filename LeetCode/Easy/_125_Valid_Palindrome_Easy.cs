namespace LeetCode.Easy125
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            s = s.ToLower();
            while (l < r)
            {
                while (l < r && (s[l] < 'a' || s[l] > 'z') && (s[l] < '0' || s[l] > '9'))
                    l++;
                while (l < r && (s[r] < 'a' || s[r] > 'z') && (s[r] < '0' || s[r] > '9'))
                    r--;
                if (s[l] != s[r])
                    return false;
                l++;
                r--;
            }
            return true;
        }
    }
}
