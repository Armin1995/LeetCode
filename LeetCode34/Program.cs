using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 在排序数组中查找元素的第一个和最后一个位置
/// </summary>
namespace LeetCode34
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result[0] = i;
                    break;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == target)
                {
                    result[1] = i;
                    break;
                }
            }

            return result;
            return result;
        }
    }
}
