using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode897
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        TreeNode cur;
        public TreeNode IncreasingBST(TreeNode root)
        {
            var dummy = new TreeNode();
            cur = dummy;
            Helper(root);
            return dummy.right;
        }
        private void Helper(TreeNode node)
        {
            if (node == null) return;
            Helper(node.left);
            node.left = null;
            cur.right = node;
            cur = node;
            Helper(node.right);
        }
    }
}
