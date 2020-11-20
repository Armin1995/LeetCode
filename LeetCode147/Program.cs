using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode147
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(4);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(1);
            ListNode node4 = new ListNode(3);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            Solution s = new Solution();
            s.InsertionSortList(node1);
        }
    }

    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode newHead = new ListNode(0);
            ListNode node = head;
            while (node != null)
            {
                ListNode next = node.next;
                //在排好序的链表中找到合适的位置, 插入
                ListNode prevNode = newHead;
                ListNode sortNode = newHead.next;
                while (sortNode != null)
                {
                    if (node.val > sortNode.val)
                    {
                        prevNode = sortNode;
                        sortNode = sortNode.next;
                    }
                    else
                    {
                        break;
                    }
                }
                prevNode.next = node;
                node.next = sortNode;

                node = next;
            }
            return newHead.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
