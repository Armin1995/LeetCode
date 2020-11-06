using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1356
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };

            Solution s = new Solution();
            var result = s.SortByBits(values);
            foreach (var value in result)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] SortByBits(int[] arr)
        {
            List<Tuple<int, int>> valueCountDict = new List<Tuple<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                valueCountDict.Add(new Tuple<int, int>(arr[i], GetCount(arr[i])));
            }
            return valueCountDict.OrderBy(o => o.Item2).ThenBy(o => o.Item1).ToList().ConvertAll(o => o.Item1).ToArray();
        }
        private int GetCount(int value)
        {
            int count = 0;
            while (value != 0)
            {
                if (value % 2 == 1)
                {
                    count++;
                }
                value /= 2;
            }
            return count;
        }
    }
}
