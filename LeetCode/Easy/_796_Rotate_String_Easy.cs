namespace LeetCode796;

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;
        if (!(s + s).Contains(goal))
            return false;
        return true;
    }
}
/*
public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s == goal)
            return true;
        for (int i = 0; i < goal.Length; i++)
        {
            string ext = goal.Substring(0, i + 1);
            if (!s.Contains(ext))
            {
                if (s == goal.Substring(0, i) + goal.Substring(i, goal.Length - i) || s == goal.Substring(i, goal.Length - i) + goal.Substring(0, i))
                {
                    return true;
                }
                else
                    return false;
            }
        }
        return false;
    }
}
*/