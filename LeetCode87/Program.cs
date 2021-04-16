using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 87. 扰乱字符串
/// </summary>
namespace LeetCode87
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var r = s.IsScramble("great", "rgeat");

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsScramble(string s1, string s2)
        {
            char[] chs1 = s1.ToCharArray();
            char[] chs2 = s2.ToCharArray();
            int l1 = chs1.Length;
            int l2 = chs2.Length;
            if (l1 != l2)
            {
                return false;
            }

            bool[,,] dp = new bool[l1, l1, l1 + 1];
            // 初始化单个字符的情况
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l1; j++)
                {
                    dp[i, j, 1] = chs1[i] == chs2[j];
                }
            }

            // 枚举区间长度 2～n
            for (int len = 2; len <= l1; len++)
            {
                // 枚举 S 中的起点位置
                for (int i = 0; i <= l1 - len; i++)
                {
                    // 枚举 T 中的起点位置
                    for (int j = 0; j <= l1 - len; j++)
                    {
                        // 枚举划分位置
                        for (int k = 1; k <= len - 1; k++)
                        {
                            // 第一种情况：S1 -> T1, S2 -> T2
                            if (dp[i, j, k] && dp[i + k, j + k, len - k])
                            {
                                dp[i, j, len] = true;
                                break;
                            }
                            // 第二种情况：S1 -> T2, S2 -> T1
                            // S1 起点 i，T2 起点 j + 前面那段长度 len-k ，S2 起点 i + 前面长度k
                            if (dp[i, j + len - k, k] && dp[i + k, j, len - k])
                            {
                                dp[i, j, len] = true;
                                break;
                            }
                        }
                    }
                }
            }

            return dp[0, 0, l1];
        }
    }
}
