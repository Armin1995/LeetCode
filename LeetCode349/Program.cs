using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 两个数组的交集
/// </summary>
namespace LeetCode349
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).Distinct().ToArray();
        }
    }
}
