using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 最接近原点的 K 个点
/// </summary>
namespace LeetCode973
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            if (points == null || points.Length == 0 || K == 0)
            {
                return null;
            }
            var indexDistanceDict = new Dictionary<int, double>();
            for (int i = 0; i < points.Length; i++)
            {
                var distance = Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2);
                indexDistanceDict.Add(i, distance);
            }
            var indexList = indexDistanceDict.OrderBy(o => o.Value).Take(K).ToDictionary(o => o.Key, v => v.Value).Keys.ToList();
            return indexList.ConvertAll(o => points[o]).ToArray();
        }
    }
}
