using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode142
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head != null)
            {
                var tempList = new List<ListNode>() { head };
                while (head.next != null)
                {
                    head = head.next;
                    if (tempList.Contains(head))
                    {
                        return head;
                    }
                    else
                    {
                        tempList.Add(head);
                    }
                }
            }
            return null;
        }
    }
}
