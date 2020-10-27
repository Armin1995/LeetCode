using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode343
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.IntegerBreak(58);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    class Solution
    {
        public int IntegerBreak(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 2; i <= n; i++)
            {
                int curMax = 0;
                for (int j = 1; j < i; j++)
                {
                    curMax = Math.Max(curMax, Math.Max(j * (i - j), j * dp[i - j]));
                }
                dp[i] = curMax;
            }
            return dp[n];
        }
    }
}
