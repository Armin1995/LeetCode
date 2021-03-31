using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode a7 = new ListNode(9, null);
            ListNode a6 = new ListNode(9, a7);
            ListNode a5 = new ListNode(9, a6);
            ListNode a4 = new ListNode(9, a5);
            ListNode a3 = new ListNode(9, a4);
            ListNode a2 = new ListNode(9, a3);
            ListNode a1 = new ListNode(9, a2);

            ListNode b4 = new ListNode(9, null);
            ListNode b3 = new ListNode(9, b4);
            ListNode b2 = new ListNode(9, b3);
            ListNode b1 = new ListNode(9, b2);

            Solution s = new Solution();
            var c1 = s.AddTwoNumbers(a1, b1);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<ListNode> nodes = new List<ListNode>();

            AddTwoNumbers(l1, l2, ref nodes);

            for (int i = 0; i < nodes.Count - 1; i++)
            {
                nodes[i].next = nodes[i + 1];
            }

            return nodes.First();
        }

        public void AddTwoNumbers(ListNode l1, ListNode l2, ref List<ListNode> nodes, int val = 0)
        {
            if (l1 != null || l2 != null || val != 0)
            {
                var v1 = 0;
                if (l1 != null)
                {
                    v1 = l1.val;
                }

                var v2 = 0;
                if (l2 != null)
                {
                    v2 = l2.val;
                }

                var sum = val + v1 + v2;
                if (sum >= 10)
                {
                    sum -= 10;
                    val = 1;
                }
                else
                {
                    val = 0;
                }

                nodes.Add(new ListNode(sum));

                AddTwoNumbers(l1?.next, l2?.next, ref nodes, val);
            }
        }
    }
}
