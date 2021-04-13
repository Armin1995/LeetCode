using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 783. 二叉搜索树节点最小距离
/// </summary>
namespace LeetCode783
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node3 = new TreeNode(3);
            TreeNode node2 = new TreeNode(2, node1, node3);
            TreeNode node6 = new TreeNode(6);
            TreeNode node4 = new TreeNode(4, node2, node6);
            Solution s = new Solution();
            var r = s.MinDiffInBST(node4);
            Console.WriteLine(r);
            Console.ReadKey();
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
        public int MinDiffInBST(TreeNode root)
        {
            var list = new List<int>();
            GetList(root, ref list);

            var min = int.MaxValue;
            for (int i = 0; i < list.Count - 1; i++)
            {
                min = Math.Min(min, list[i + 1] - list[i]);
            }
            return min;
        }

        public void GetList(TreeNode node, ref List<int> list)
        {
            if (node.left != null)
            {
                GetList(node.left, ref list);
            }

            list.Add(node.val);

            if (node.right != null)
            {
                GetList(node.right, ref list);
            }
        }
    }
}
