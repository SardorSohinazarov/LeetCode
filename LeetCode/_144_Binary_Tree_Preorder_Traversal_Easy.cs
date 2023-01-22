namespace LeetCode144;//solved

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> list = new List<int>();

        Iterate(root);

        void Iterate(TreeNode node){
            if(node != null)
            {
                list.Add(node.val);
                Iterate(node.left);
                Iterate(node.right);
            }
        }
        return list;
    }
}
