namespace LeetCode20
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            while (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    s = s.Replace("{}", "");
                    s = s.Replace("[]", "");
                    s = s.Replace("()", "");
                }
            }
            return stack.Count == 0;
        }
    }
/*    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    stack.Push(s[i]);
                else if (s[i] == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (s[i] == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (s[i] == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else return false;
            }
            return stack.Count == 0;
        }
    }*/
}
