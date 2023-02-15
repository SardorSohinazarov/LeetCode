namespace LeetCode.Easy
{
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;

            Sardor(root);

            void Sardor(TreeNode root)
            {
                if (root is not null)
                {
                    if (root.left is not null && root.left.left == null && root.left.right == null)
                        sum += root.left.val;
                    Sardor(root.left);
                    Sardor(root.right);
                }
            }
            return sum;
        }
    }
}
