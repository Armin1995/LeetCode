using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode925
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var b = s.IsLongPressedName("a", "aaaaaaaaaaaaaaaa");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsLongPressedName(string name, string typed)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(typed))
            {
                return false;
            }
            var nameSort = SortStr(name);
            var typedSort = SortStr(typed);
            if (nameSort.Count == typedSort.Count)
            {
                for (int i = 0; i < nameSort.Count; i++)
                {
                    if (nameSort[i].Length > typedSort[i].Length || nameSort[i].First() != typedSort[i].First())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private List<string> SortStr(string str)
        {
            var result = new List<string>();
            if (str.Length == 1)
            {
                result.Add(str);
            }
            else
            {
                string s = string.Empty;
                for (int i = 0; i < str.Length - 1; i++)
                {
                    var c1 = str[i];
                    s += c1;
                    var c2 = str[i + 1];
                    if (c2 != c1)
                    {
                        result.Add(s);
                        s = string.Empty;
                    }
                }
                if (!string.IsNullOrEmpty(s))
                {
                    result.Add(s);
                }
                if (result.Last().First() == str.Last())
                {
                    var last = result.Last();
                    last += str.Last();
                    result[result.Count - 1] = last;
                }
                else
                {
                    result.Add(str.Last().ToString());
                }
            }
            return result;
        }
    }
}
