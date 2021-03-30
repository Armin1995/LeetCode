using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 190. 颠倒二进制位
/// </summary>
namespace LeetCode190
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var n = Convert.ToUInt32("00000010100101000001111010011100", 2);
            var r = s.reverseBits(n);
        }
    }

    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result += ((n & (1U << (31 - i))) != 0 ? 1U << i : 0);
            }
            return result;
        }
    }
}
