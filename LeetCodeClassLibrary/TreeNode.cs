using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
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

        public TreeNode(int?[] array)
        {
            var n = Math.Ceiling(Math.Log(array.Length + 1, 2));//2^N == 8
            TreeNode root = null;
            TreeNode[] lastTreeNodes = null;
            for (int i = 0; i < n; i++)
            {
                var max = (int)Math.Pow(2, i);
                TreeNode[] currentTreeNodes = new TreeNode[max];
                for (int j = 0; j < max; j++)
                {
                    var index = max - 1 + j;
                    if (index < array.Length)
                    {
                        if (array[index] != null)
                        {
                            TreeNode treeNode = new TreeNode(array[index].Value);
                            if (lastTreeNodes != null)
                            {
                                var dex = (int)Math.Ceiling((double)(j + 1) / 2 - 1);
                                if ((double)(j + 1) / 2 != (j + 1) / 2)
                                {
                                    lastTreeNodes[dex].left = treeNode;
                                }
                                else
                                {
                                    lastTreeNodes[dex].right = treeNode;
                                }
                            }
                            currentTreeNodes[j] = treeNode;
                        }
                        else
                        {
                            currentTreeNodes[j] = null;
                        }
                    }
                }
                lastTreeNodes = currentTreeNodes;
                if (lastTreeNodes.Length == 1)
                {
                    root = lastTreeNodes.First();
                }
            }

            this.val = root.val;
            this.left = root.left;
            this.right = root.right;
        }

    }
}
