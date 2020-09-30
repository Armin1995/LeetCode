using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode701
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root != null)
            {
                if (val > root.val)
                {
                    if (root.right != null)
                    {
                        InsertIntoBST(root.right, val);
                    }
                    else
                    {
                        root.right = new TreeNode(val);
                    }
                }
                else if (val < root.val)
                {
                    if (root.left != null)
                    {
                        InsertIntoBST(root.left, val);
                    }
                    else
                    {
                        root.left = new TreeNode(val);
                    }
                }
            }
            else
            {
                root = new TreeNode(val);
            }
            return root;
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
}
