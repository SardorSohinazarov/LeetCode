namespace LeetCode.Easy434
{
    public class Solution
    {
        public int CountSegments(string s)
        {
            return s.Split(' ').ToList().Where(x => x.Length != 0).Count();
        }
    }
}