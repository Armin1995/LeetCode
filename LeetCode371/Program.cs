using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 两整数之和
/// </summary>
namespace LeetCode371
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int GetSum(int a, int b)
        {
            if (b == 0) return a;
            return GetSum(a ^ b, (a & b) << 1);
        }
    }
}
