using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1030
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            if (R == 0 || C == 0)
            {
                var result = new List<int[]>();
                return result.ToArray();
            }
            Dictionary<int[], int> pointDistanceDict = new Dictionary<int[], int>();
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    int[] p = new int[] { i, j };
                    var distance = Math.Abs(r0 - i) + Math.Abs(c0 - j);
                    pointDistanceDict.Add(p, distance);
                }
            }
            return pointDistanceDict.OrderBy(o => o.Value).ToDictionary(o => o.Key, v => v.Value).Keys.ToArray();
        }
    }
}
