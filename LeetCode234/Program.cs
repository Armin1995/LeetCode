using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode234
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
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> vals = new List<int>();

            // 将链表的值复制到数组中
            ListNode currentNode = head;
            while (currentNode != null)
            {
                vals.Add(currentNode.val);
                currentNode = currentNode.next;
            }

            // 使用双指针判断是否回文
            int front = 0;
            int back = vals.Count - 1;
            while (front < back)
            {
                if (vals[front] != vals[back])
                {
                    return false;
                }
                front++;
                back--;
            }
            return true;
        }

    }
}
