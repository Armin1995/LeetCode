using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 自由之路
/// </summary>
namespace LeetCode514
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int FindRotateSteps(string ring, string key)
        {
            int n = ring.Length;
            int m = key.Length;
            List<int>[] pos = new List<int>[26];
            for (int i = 0; i < 26; i++)
            {
                pos[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                pos[ring[i] - 'a'].Add(i);
            }
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }
            foreach (var i in pos[key[0] - 'a'])
            {
                dp[0, i] = Math.Min(i, n - i) + 1;
            }
            for (int i = 1; i < m; i++)
            {
                foreach (var j in pos[key[i] - 'a'])
                {
                    foreach (var k in pos[key[i - 1] - 'a'])
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i - 1, k] + Math.Min(Math.Abs(j - k), n - Math.Abs(j - k)) + 1);
                    }
                }
            }
            int[] result = new int[dp.GetLength(m - 1)];
            for (int i = 0; i < dp.GetLength(m - 1); i++)
            {
                result[i] = dp[m - 1, i];
            }
            return result.Min();
        }
    }
}
