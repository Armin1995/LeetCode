using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1207
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// 独一无二的出现次数
    /// </summary>
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            if (arr == null)
            {
                return false;
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] = dict[item] + 1;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            foreach (var item in dict)
            {
                if (dict2.ContainsKey(item.Value))
                {
                    dict2[item.Value] = dict2[item.Value] + 1;
                }
                else
                {
                    dict2.Add(item.Value, 1);
                }
            }
            return dict.Count() == dict2.Count();
        }
    }
}
