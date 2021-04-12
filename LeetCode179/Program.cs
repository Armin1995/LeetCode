using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode179
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0,0};
            Solution s = new Solution();
            var r = s.LargestNumber(nums);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            string str = "";
            Array.Sort(nums, (x1, x2) =>
            {
                string s1 = x1.ToString();
                string s2 = x2.ToString();
                string s12 = s1 + s2;
                string s21 = s2 + s1;
                return s21.CompareTo(s12);
            }
            );

            foreach (int i in nums)
                str += i.ToString();

            while (str.Length > 1 && str[0] == '0')//排除字符串前的零
            {
                str = str.Substring(1);
            }
            return str;
        }
    }

}
