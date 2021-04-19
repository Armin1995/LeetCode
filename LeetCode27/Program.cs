using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 27. 移除元素
/// </summary>
namespace LeetCode27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2, 3, 4, 5, 5, 6, 7, 8, 7, 6, 6, 9 };
            Solution s = new Solution();
            var r = s.RemoveElement(nums, 6);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int end = nums.Length - 1;
            for (int i = 0; i <= end; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[end];
                    i--;
                    end--;
                }
            }
            return end + 1;
        }
    }
}
