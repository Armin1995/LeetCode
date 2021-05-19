using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1738. 找出第 K 大的异或坐标值
/// </summary>
namespace LeetCode1738
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] matrix = new int[][] { new int[] { 5, 2 }, new int[] { 1, 6 } };
            var r = s.KthLargestValue(matrix,1);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int KthLargestValue(int[][] matrix, int k)
        {
            int m = matrix.Length, n = matrix[0].Length;
            int[,] pre = new int[m + 1, n + 1];
            List<int> results = new List<int>();
            for (int i = 1; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    pre[i, j] = pre[i - 1, j] ^ pre[i, j - 1] ^ pre[i - 1, j - 1] ^ matrix[i - 1][j - 1];
                    results.Add(pre[i, j]);
                }
            }

            results.Sort(
                delegate (int num1, int num2)
                {
                    return num2 - num1;
                }
            );
            return results[k - 1];
        }
    }
}
