using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 83. 删除排序链表中的重复元素
/// </summary>
namespace LeetCode83
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node7 = new ListNode(5, null);
            ListNode node6 = new ListNode(4, node7);
            ListNode node5 = new ListNode(4, node6);
            ListNode node4 = new ListNode(3, node5);
            ListNode node3 = new ListNode(3, node4);
            ListNode node2 = new ListNode(2, node3);
            ListNode node1 = new ListNode(1, node2);

            //ListNode node5 = new ListNode(3, null);
            //ListNode node4 = new ListNode(2, node5);
            //ListNode node3 = new ListNode(1, node4);
            //ListNode node2 = new ListNode(1, node3);
            //ListNode node1 = new ListNode(1, node2);

            Solution s = new Solution();
            var result = s.DeleteDuplicates(node1);
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            var dummy = new ListNode(0, head);
            var cur = dummy;
            while (cur.next != null && cur.next.next != null)
            {
                if (cur.next.val == cur.next.next.val)
                {
                    var val = cur.next.val;
                    while (cur.next.next != null && cur.next.next.val == val)
                    {
                        cur.next = cur.next.next;
                    }

                }
                else
                {
                    cur = cur.next;
                }
            }

            return dummy.next;
        }
    }
}
