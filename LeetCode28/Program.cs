using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode28
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";

            Solution s = new Solution();
            var r = s.StrStr(haystack, needle);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (string.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
                {
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            goto here;
                        }
                    }
                    return i;
                }
                here: { }
                //var subStr = haystack.Substring(i);
                //if (subStr.StartsWith(needle))
                //{
                //    return i;
                //}
            }

            return -1;
        }
    }
}
