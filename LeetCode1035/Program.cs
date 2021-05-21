using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1035. 不相交的线
/// </summary>
namespace LeetCode1035
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var nums1 = new int[] { 1, 3, 7, 1, 7, 5 };
            var nums2 = new int[] { 1, 9, 2, 5, 1 };
            var r = s.MaxUncrossedLines(nums1, nums2);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int m = nums1.Length, n = nums2.Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                int num1 = nums1[i - 1];
                for (int j = 1; j <= n; j++)
                {
                    int num2 = nums2[j - 1];
                    if (num1 == num2)
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[m, n];
        }
    }
}
