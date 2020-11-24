using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode452
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> points = new List<int[]>() { new int[] { 10, 16 }, new int[] { 2, 8 }, new int[] { 1, 6 }, new int[] { 7, 12 } };

            Solution s = new Solution();
            s.FindMinArrowShots(points.ToArray());
        }
    }

    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points == null || points.Length == 0)
            {
                return 0;
            }
            Array.Sort(points, (x1, x2) => x1[1].CompareTo(x2[1]));
            int temp = points[0][1];
            int result = 1;
            foreach (var point in points)
            {
                if (point[0] > temp)
                {
                    temp = point[1];
                    result++;
                }
            }
            return result;
        }
    }
}
