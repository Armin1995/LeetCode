using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 奇偶链表
/// </summary>
namespace LeetCode328
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            ListNode node5 = new ListNode(5);
            ListNode node4 = new ListNode(4, node5);
            ListNode node3 = new ListNode(3, node4);
            ListNode node2 = new ListNode(2, node3);
            ListNode node1 = new ListNode(1, node2);
            s.OddEvenList(node1);
        }
    }

    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            ListNode second;
            if (head != null)
            {
                var first = head;
            }
            else
            {
                return head;
            }
            if (head.next != null)
            {
                second = head.next;
            }
            else
            {
                return head;
            }

            CheckNext(head, true, second);

            return head;
        }

        private void CheckNext(ListNode node, bool isOdd, ListNode second)
        {
            if (node.next.next != null)
            {
                var originNext = node.next;
                node.next = node.next.next;
                CheckNext(originNext, !isOdd, second);
            }
            else
            {
                if (isOdd)
                {
                    node.next.next = null;
                    node.next = second;
                }
                else
                {
                    node.next.next = second;
                    node.next = null;
                }
            }
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

}
