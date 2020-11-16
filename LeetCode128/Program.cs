using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 最长连续序列
/// </summary>
namespace LeetCode128
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new List<int>() { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }.ToArray();

            Solution s = new Solution();
            s.LongestConsecutive(nums);
        }
    }

    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>();
            foreach (var num in nums)
            {
                numSet.Add(num);
            }

            int longestStreak = 0;

            for (int i = 0; i < numSet.Count; i++)
            {
                var num = numSet.ElementAt(i);
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }
            return longestStreak;
        }
    }
}
