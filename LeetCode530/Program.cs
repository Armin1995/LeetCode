using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode530
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> values = new List<int>();
            DFS(root, values);
            int min = int.MaxValue;
            for (int i = 0; i < values.Count - 1; i++)
            {
                var dif = values[i + 1] - values[i];
                min = Math.Min(dif, min);
            }
            return min;
        }

        public void DFS(TreeNode root, List<int> values)
        {
            if (root == null)
            {
                return;
            }
            DFS(root.left, values);
            values.Add(root.val);
            DFS(root.right, values);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
