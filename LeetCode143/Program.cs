using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode143
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
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public void ReorderList(ListNode head)
        {
            if (head == null)
            {
                return;
            }
            var nodeList = new List<ListNode>() { head };
            while (head.next != null)
            {
                head = head.next;
                nodeList.Add(head);
            }
            var reverseList = new List<ListNode>(nodeList);
            reverseList.Reverse();
            if (nodeList.Count % 2 == 0)
            {
                for (int i = 0; i < nodeList.Count / 2; i++)
                {
                    if (i == nodeList.Count / 2 - 1)
                    {
                        nodeList[i].next = reverseList[i];
                        reverseList[i].next = null;
                    }
                    else
                    {
                        var originNext = nodeList[i].next;
                        nodeList[i].next = reverseList[i];
                        reverseList[i].next = originNext;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nodeList.Count / 2 + 1; i++)
                {
                    if (i == nodeList.Count / 2)
                    {
                        nodeList[i].next = null;
                    }
                    else
                    {
                        var originNext = nodeList[i].next;
                        nodeList[i].next = reverseList[i];
                        reverseList[i].next = originNext;
                    }
                }
            }
        }
    }
}
