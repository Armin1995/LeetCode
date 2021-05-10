using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeClassLibrary;

/// <summary>
/// 872. 叶子相似的树
/// </summary>
namespace LeetCode872
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            TreeNode treeNode1 = new TreeNode(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });
            TreeNode treeNode2 = new TreeNode(new int?[] { 3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8 });
            var r = s.LeafSimilar(treeNode1, treeNode2);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leafList1 = new List<int>();
            var leafList2 = new List<int>();
            GetLeafNode(root1, leafList1);
            GetLeafNode(root2, leafList2);

            if (leafList1.Count == leafList2.Count)
            {
                for (int i = 0; i < leafList1.Count; i++)
                {
                    if (leafList1[i] != leafList2[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        private void GetLeafNode(TreeNode node, List<int> leafList)
        {
            if (node.left != null)
            {
                GetLeafNode(node.left, leafList);
            }

            if (node.right != null)
            {
                GetLeafNode(node.right, leafList);
            }

            if (node.left == null && node.right == null)
            {
                leafList.Add(node.val);
            }
        }
    }
}
