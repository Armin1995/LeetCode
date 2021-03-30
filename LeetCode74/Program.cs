using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 74. 搜索二维矩阵
/// </summary>
namespace LeetCode74
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] matrix = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } };
            var r = s.SearchMatrix(matrix, 13);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            bool result = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (target <= matrix[i][matrix[i].Length - 1])
                {
                    return SearchElement(matrix[i], target, 0, matrix[i].Length - 1);
                }
            }

            return result;
        }

        public bool SearchElement(int[] array, int target, int low, int high)
        {
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (target == array[middle])
                {
                    return true;
                }
                else if (target > array[middle])
                {
                    low = middle + 1;
                }
                else if (target < array[middle])
                {
                    high = middle - 1;
                }
            }
            return false;
        }
    }
}
