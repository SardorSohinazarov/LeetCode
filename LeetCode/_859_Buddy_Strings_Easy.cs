namespace LeetCode859
{
    public class Solution
    {
        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length) return false;

            List<char> l1 = new List<char>();
            List<char> l2 = new List<char>();
            for (int i = 0; i < goal.Length; i++)
                if (goal[i] != s[i])
                {
                    l1.Add(s[i]);
                    l2.Add(goal[i]);
                }
            if (l1.Count == l2.Count && l2.Count == 2 && l1[0] == l2[1] && l1[1] == l2[0])
                return true;
            for(char i = 'a'; i<= 'z'; i++)
            {
                if (s.Contains(i))
                {
                    s  = s.Remove(s.IndexOf(i), 1);
                    if (s.Contains(i))
                        return true;
                }
            }

            return false;
        }
    }
}
