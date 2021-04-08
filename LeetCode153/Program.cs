using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 153. 寻找旋转排序数组中的最小值
/// </summary>
namespace LeetCode153
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 10, 11, 15, 16, 1, 2, 5, 7, 8, 9 };
            Solution s = new Solution();
            var r = s.FindMin(nums);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low < high)
            {
                var mid = low + (high - low) / 2;
                if (nums[mid] < nums[high])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return nums[low];
        }
    }
}
