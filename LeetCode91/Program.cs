using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 91. 解码方法
/// </summary>
namespace LeetCode91
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "11106";
            Solution so = new Solution();
            var r = so.NumDecodings(s);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int NumDecodings(string s)
        {
            if (s[0] == '0')
            {
                return 0;
            }
            int pre = 1, cur = 1;
            for (int i = 1; i < s.Length; i++)
            {
                int tmp = cur;
                if (s[i] == '0')
                {
                    if (s[i - 1] == '1' || s[i - 1] == '2')
                    {
                        cur = pre;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (s[i - 1] == '1' || (s[i - 1] == '2' && s[i] >= '1' && s[i] <= '6'))
                {
                    cur = cur + pre;
                }
                pre = tmp;
            }
            return cur;
        }
    }
}
