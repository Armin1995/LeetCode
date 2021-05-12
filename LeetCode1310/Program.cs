using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1310. 子数组异或查询
/// </summary>
namespace LeetCode1310
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] arr = new int[] { 4, 8, 2, 10 };
            int[][] queries = new int[][] { new int[] { 2, 3 }, new int[] { 1, 3 }, new int[] { 0, 0 }, new int[] { 0, 3 } };
            var r = s.XorQueries(arr, queries);
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            int n = arr.Length;
            int[] xors = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                xors[i + 1] = xors[i] ^ arr[i];
            }

            int[] r = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                r[i] = xors[queries[i][0]] ^ xors[queries[i][1] + 1];
            }
            return r;
        }
    }
}
