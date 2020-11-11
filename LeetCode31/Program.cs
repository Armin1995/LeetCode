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
            Solution s = new Solution();
            int[] nums = new int[] { 1, 2, 5, 9, 1, 7, 3 };
            s.NextPermutation(nums);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return;
            }
            int i = nums.Length - 2;
            int j = nums.Length - 1;
            int k = nums.Length - 1;

            // find: A[i]<A[j]
            while (i >= 0 && nums[i] >= nums[j])
            {
                i--;
                j--;
            }

            if (i >= 0)// 不是最后一个排列
            {
                // find: A[i]<A[k]
                while (nums[i] >= nums[k])
                {
                    k--;
                }
                // swap A[i], A[k]
                var temp = nums[i];
                nums[i] = nums[k];
                nums[k] = temp;
            }
            // reverse A[j:end]
            for (i = j, j = nums.Length - 1; i < j; i = i + 1, j = j - 1)
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}
