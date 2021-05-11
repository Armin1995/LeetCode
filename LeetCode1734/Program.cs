using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1734. 解码异或后的排列
/// x XOR y = z
/// x = y XOR z = y XOR (x XOR y) = (y XOR y) XOR x = 0 XOR x = x
/// </summary>
namespace LeetCode1734
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[] { 3, 1 };
            Solution s = new Solution();
            var r = s.Decode(i);
            foreach (var a in r)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] Decode(int[] encoded)
        {
            int n = encoded.Length;// 得到编码后的长度
            int[] perm = new int[n + 1];// 定义原本的整数数组perm
            int abcde = 0;// 初始化，这个变量用于存放perm中所有数值进行异或的结果
            for (int i = 1; i <= n + 1; i++)// perm中所有数值进行异或 
            {
                abcde ^= i;
            }
            int bcde = 0; // 为了得到perm的第一个数值，需要初始化一个“BCDE”
            for (int i = 1; i < n; i += 2)//  “BCDE”的求值，就是encoded中从1开始，步长为2地取值进行异或的结果 
            {
                bcde ^= encoded[i];
            }
            perm[0] = abcde ^ bcde;// 得到第一个数A

            for (int i = 1; i <= n; i++)
            {
                perm[i] = perm[i - 1] ^ encoded[i - 1];// 此时，本题转换为力扣1720
            }

            return perm;
        }
    }
}
