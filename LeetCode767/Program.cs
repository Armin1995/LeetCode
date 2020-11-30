using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 重构字符串
/// </summary>
namespace LeetCode767
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.ReorganizeString("aaabbbccc");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string ReorganizeString(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return string.Empty;
            }
            var length = S.Length;
            Dictionary<char, int> charTimes = new Dictionary<char, int>();
            foreach (char c in S)
            {
                if (charTimes.ContainsKey(c))
                {
                    charTimes[c] = charTimes[c] + 1;
                }
                else
                {
                    charTimes.Add(c, 1);
                }
            }
            charTimes = charTimes.OrderByDescending(o => o.Value).ToDictionary(o => o.Key, v => v.Value);

            if ((length - charTimes.First().Value) + 1 >= charTimes.First().Value)
            {
                string result = string.Empty;
                char endChar = charTimes.First().Key;
                for (int i = 0; i < S.Length; i++)
                {
                    if (!string.IsNullOrEmpty(result))
                    {
                        var kv = charTimes.FirstOrDefault(o => o.Key != endChar && o.Value > 0);
                        endChar = kv.Key;
                    }
                    result += endChar;
                    var value = charTimes[endChar];
                    charTimes.Remove(endChar);
                    charTimes = charTimes.OrderByDescending(o => o.Value).ToDictionary(o => o.Key, v => v.Value);
                    if (value - 1 > 0)
                    {
                        charTimes.Add(endChar, value - 1);
                    }
                }
                return result;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
