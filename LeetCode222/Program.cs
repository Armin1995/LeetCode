using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode222
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
        public TreeNode(int x) { val = x; }
    }

    class Solution
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = CountLevel(root.left);
            int right = CountLevel(root.right);
            if (left == right)
            {
                return CountNodes(root.right) + (1 << left);
            }
            else
            {
                return CountNodes(root.left) + (1 << right);
            }
        }
        private int CountLevel(TreeNode root)
        {
            int level = 0;
            while (root != null)
            {
                level++;
                root = root.left;
            }
            return level;
        }
    }
}
