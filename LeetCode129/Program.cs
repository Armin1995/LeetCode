using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 129 求根到叶子节点数字之和
/// </summary>
namespace LeetCode129
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

    public class Solution
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            List<int> sums = new List<int>();
            Sum(root, "", ref sums);
            return sums.Sum();
        }

        public void Sum(TreeNode node, string combime, ref List<int> sums)
        {
            combime += node.val;

            if (node.left == null && node.right == null)
            {
                sums.Add(int.Parse(combime));
                combime = combime.Substring(0, combime.Length - 1);
            }

            if (node.left != null)
            {
                Sum(node.left, combime, ref sums);
            }

            if (node.right != null)
            {
                Sum(node.right, combime, ref sums);
            }
        }
    }
}
