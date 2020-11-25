using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1370
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.SortString("leetcode");
        }
    }

    public class Solution
    {
        public string SortString(string s)
        {
            StringBuilder str = new StringBuilder();
            int[] charCount = new int[26];
            foreach (var c in s)
            {
                charCount[c - 97]++;
            }
            var max = charCount.Max();
            for (int i = 0; i < max; i++)
            {
                var tempStr = string.Empty;
                for (int j = 0; j < charCount.Length; j++)
                {
                    if (charCount[j] != 0)
                    {
                        tempStr += (char)(j + 97);
                        charCount[j]--;
                    }

                }
                if (i % 2 == 0)
                {
                    str.Append(tempStr);
                }
                else
                {
                    str.Append(tempStr.Reverse().ToArray());
                }
            }

            return str.ToString();
        }
    }
}
