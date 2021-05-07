using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1486. 数组异或操作
/// x⊕x=0；
/// x⊕y = y⊕x   x⊕y=y⊕x（交换律）；
/// (x⊕y)⊕z = x⊕(y⊕z)(x⊕y)⊕z = x⊕(y⊕z)（结合律）；
/// x⊕y⊕y=x（自反性）；
/// ∀i∈Z，有 4i⊕(4i+1)⊕(4i+2)⊕(4i+3) = 0
/// </summary>
namespace LeetCode1486
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var r = s.XorOperation(5, 0);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                int cur = start + 2 * i;
                r ^= cur;
            }
            return r;
        }
    }
}
