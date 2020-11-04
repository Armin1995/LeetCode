using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 插入区间
/// </summary>
namespace LeetCode57
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[][] { new int[] { 4, 5 } };
            int[] newInterval = new int[] { 2, 3 };
            Solution s = new Solution();
            s.Insert(intervals, newInterval);
        }
    }

    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var left = newInterval[0];
            var right = newInterval[1];
            var includeList = new List<int>();
            var needAdd = true;
            for (int i = 0; i < intervals.Length; i++)
            {
                var interval = intervals[i];
                var l = interval[0];
                var r = interval[1];
                if (r < left)
                {

                }
                else if (r == left)
                {
                    includeList.Add(i);
                }
                else if (l < left && left < r && r < right)
                {
                    includeList.Add(i);
                }
                else if (l < left && r == right)
                {
                    includeList.Add(i);
                }
                else if (l < left && r > right)
                {
                    needAdd = false;
                }
                else if (l == left && r < right)
                {
                    includeList.Add(i);
                }
                else if (l == left && r == right)
                {
                    needAdd = false;
                }
                else if (l == left && r > right)
                {
                    needAdd = false;
                }
                else if (l > left && r < right)
                {
                    includeList.Add(i);
                }
                else if (l > left && r == right)
                {
                    includeList.Add(i);
                }
                else if (left < l && l < right && right < r)
                {
                    includeList.Add(i);
                }
                else if (l == right)
                {
                    includeList.Add(i);
                }
                else if (l > right)
                {

                }
            }

            if (includeList.Count != 0)
            {
                var combine = GetCombine(intervals, includeList, left, right);
                for (int i = 0; i < includeList.Count; i++)
                {
                    intervals[includeList[i]] = combine;
                }
                intervals = intervals.Distinct().ToArray();
            }
            else if (needAdd)
            {
                var newList = intervals.ToList();
                newList.Add(newInterval);
                intervals = newList.OrderBy(o => o[0]).ToArray();
            }

            return intervals;
        }

        private int[] GetCombine(int[][] intervals, List<int> includeList, int min, int max)
        {
            min = Math.Min(intervals[includeList[0]][0], min);
            max = Math.Max(intervals[includeList[includeList.Count - 1]][1], max);
            return new int[] { min, max };
        }
    }
}
