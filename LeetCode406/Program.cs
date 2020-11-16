using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode406
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] i1 = new int[2] { 7, 0 };
            int[] i2 = new int[2] { 4, 4 };
            int[] i3 = new int[2] { 7, 1 };
            int[] i4 = new int[2] { 5, 0 };
            int[] i5 = new int[2] { 6, 1 };
            int[] i6 = new int[2] { 5, 2 };
            List<int[]> people = new List<int[]>() { i1, i2, i3, i4, i5, i6 };
            s.ReconstructQueue(people.ToArray());
        }
    }

    public class Solution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            if (people == null)
            {
                return null;
            }
            else if (people.Length == 0)
            {
                return people;
            }
            people = people.OrderByDescending(o => o.First()).ThenBy(o => o.Last()).ToArray();

            List<int[]> res = new List<int[]>();
            for (int i = 0; i < people.Length; i++)
            {
                var p = people[i];
                if (res.Count <= p[1])
                {
                    res.Add(p);
                }
                else if (res.Count > p[1])
                {
                    res.Insert(p[1], p);
                }
            }

            return res.ToArray();
        }


    }
}
