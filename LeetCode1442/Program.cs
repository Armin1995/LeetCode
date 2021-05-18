using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1442. 形成两个异或相等数组的三元组数目
/// </summary>
namespace LeetCode1442
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var r = s.CountTriplets(new int[] { 7, 11, 12, 9, 5, 2, 7, 17, 22 });
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int CountTriplets(int[] arr)
        {
            int n = arr.Length;
            int[] s = new int[n + 1];
            for (int i = 0; i < n; ++i)
            {
                s[i + 1] = s[i] ^ arr[i];
            }

            int result = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j; k < arr.Length; k++)
                    {
                        if (s[i] == s[k + 1])
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
