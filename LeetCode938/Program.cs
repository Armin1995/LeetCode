using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 938. 二叉搜索树的范围和
/// </summary>
namespace LeetCode938
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode18 = new TreeNode(18);
            TreeNode treeNode7 = new TreeNode(7);
            TreeNode treeNode3 = new TreeNode(3);
            TreeNode treeNode15 = new TreeNode(15, null, treeNode18);
            TreeNode treeNode5 = new TreeNode(5, treeNode3, treeNode7);
            TreeNode treeNode10 = new TreeNode(10, treeNode5, treeNode15);

            Solution s = new Solution();

            s.RangeSumBST(treeNode10, 7, 15);
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
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            //输入：root = [10,5,15,3,7,null,18], L = 7, R = 15
            //输出：32
            if (root == null)//判断二叉搜索树是否为空，为空输出0
            {
                return 0;
            }
            if (root.val < L)//判断值是否小于L
            {
                return RangeSumBST(root.right, L, R);//如果小于L，取右节点值进行递归
            }
            if (root.val > R)//判断值是否大于R
            {
                return RangeSumBST(root.left, L, R);//如果大于R，取左节点进行递归
            }
            int res = 0;//储存总数
            if (root.val >= L && root.val <= R)
            {
                int left = RangeSumBST(root.left, L, R);//遍历左节点
                res += root.val;
                int right = RangeSumBST(root.right, L, R);//遍历右节点
                res += (left + right);
            }
            return res;
        }
    }
}
