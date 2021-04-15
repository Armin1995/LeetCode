using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 213. 打家劫舍 II
/// </summary>
namespace LeetCode213
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 1, 1, 9, 1, 1, 8, 1, 15, 1, 1, 7 };

            Solution s = new Solution();
            var r = s.Rob(nums);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int Rob(int[] nums)
        {
            int length = nums.Length;
            if (length == 1)
            {
                return nums[0];
            }
            else if (length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            return Math.Max(RobRange(nums, 0, length - 2), RobRange(nums, 1, length - 1));
        }

        public int RobRange(int[] nums, int start, int end)
        {
            int first = nums[start], second = Math.Max(nums[start], nums[start + 1]);
            for (int i = start + 2; i <= end; i++)
            {
                int temp = second;
                second = Math.Max(first + nums[i], second);
                first = temp;
            }
            return second;
        }
    }
}
