using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode844
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool result = solution.BackspaceCompare("a#c", "b");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            StringBuilder s = new StringBuilder(S);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    if (i != 0)
                    {
                        s.Remove(i - 1, 2);
                    }
                    else
                    {
                        s.Remove(i, 1);
                    }
                    i--;
                    if (i != -1)
                    {
                        i--;
                    }
                }
            }
            StringBuilder t = new StringBuilder(T);
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#')
                {
                    if (i != 0)
                    {
                        t.Remove(i - 1, 2);
                    }
                    else
                    {
                        t.Remove(i, 1);
                    }
                    i--;
                    if (i != -1)
                    {
                        i--;
                    }
                }
            }
            if (s.ToString() == t.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
