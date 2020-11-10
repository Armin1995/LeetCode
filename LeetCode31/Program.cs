using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode31
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var current = nums[nums.Length - 1 - i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var last = nums[nums[nums.Length - 1 - j]];

                }
            }
        }
    }
}
