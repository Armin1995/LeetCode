using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode116
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            node1.left = node2;
            node1.right = node3;
            Solution solution = new Solution();
            solution.Connect(node1);
        }
    }

    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }
            int level = 0;
            Dictionary<int, List<Node>> levelNodeDict = new Dictionary<int, List<Node>>();
            LRD(root, level, levelNodeDict);
            foreach (var item in levelNodeDict)
            {

                for (int i = 0; i < item.Value.Count; i++)
                {
                    if (i == item.Value.Count - 1)
                    {
                        item.Value[i].next = null;
                    }
                    else
                    {
                        item.Value[i].next = item.Value[i + 1];
                    }
                }
            }
            return root;
        }

        public void LRD(Node node, int level, Dictionary<int, List<Node>> levelNodeDict)
        {
            level = level + 1;
            if (levelNodeDict.ContainsKey(level))
            {
                levelNodeDict[level].Add(node);
            }
            else
            {
                levelNodeDict.Add(level, new List<Node>() { node });
            }
            if (node.left != null)
            {
                LRD(node.left, level, levelNodeDict);
            }
            if (node.right != null)
            {
                LRD(node.right, level, levelNodeDict);
            }
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

}
