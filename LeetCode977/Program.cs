using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode977
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] SortedSquares(int[] A)
        {
            return A.Select(o => (int)Math.Pow(o, 2)).OrderBy(o => o).ToArray();
        }
    }
}
