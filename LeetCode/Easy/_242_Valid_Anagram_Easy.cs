namespace LeetCode.Easy//solved
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            int[] alphabit = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                alphabit[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                alphabit[t[i] - 'a']--;
            }

            for (int i = 0; i < alphabit.Length; i++)
            {
                if (alphabit[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    /*public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            char[] schar = s.ToCharArray();
            char[] tchar = t.ToCharArray();

            Array.Sort(schar);
            Array.Sort(tchar);

            for(int i = 0; i < schar.Length; i++)
            {
                if(schar[i] != tchar[i])
                    return false;
            }
            return true;
        }
    }*/
}
