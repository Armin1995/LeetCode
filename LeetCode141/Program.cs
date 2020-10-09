using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode141
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head != null)
            {
                List<ListNode> listNodes = new List<ListNode>() { head };
                while (head.next != null)
                {
                    head = head.next;
                    if (listNodes.Contains(head))
                    {
                        return true;
                    }
                    else
                    {
                        listNodes.Add(head);
                    }
                }
            }
            return false;
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
}
