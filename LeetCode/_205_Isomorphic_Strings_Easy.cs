namespace LeetCode205;//solved

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> map = new Dictionary<char, int>();
        Dictionary<char, int> map2 = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            map[s[i]] = i;
            map2[t[i]] = i;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (map[s[i]] != map2[t[i]])
            {
                return false;
            }
        }

        return true;
    }
}