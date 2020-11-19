using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 移动零
/// </summary>
namespace LeetCode283
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int b = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[b];
                    nums[b] = temp;
                    b++;
                }
            }
        }
    }
}
