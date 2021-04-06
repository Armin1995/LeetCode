using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 80. 删除有序数组中的重复项 II
/// </summary>
namespace LeetCode80
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };

            Solution s = new Solution();
            var len = s.RemoveDuplicates(nums);
            Console.WriteLine(len);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int n = nums.Length;
            if (n <= 2)
            {
                return n;
            }
            int slow = 2, fast = 2;
            while (fast < n)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            return slow;
        }
    }
}
