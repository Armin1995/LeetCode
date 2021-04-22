using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode363
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = new int[,] { };
            //Solution s = new Solution();
            //var r = s.MaxSumSubmatrix();
            //Console.WriteLine(r);
            //Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            int rows = matrix.Length, cols = matrix[0].Length, max = int.MinValue;
            for (int l = 0; l < cols; l++)
            {
                int[] rowSum = new int[rows];
                for (int r = l; r < cols; r++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        rowSum[i] += matrix[i][r];
                    }
                    max = Math.Max(max, DpMax(rowSum, k));
                    if (max == k)
                    {
                        return k;
                    }
                }
            }

            return max;
        }

        private int DpMax(int[] arr, int k)
        {
            int rollSum = arr[0], rollMax = rollSum;
            for (int i = 1; i < arr.Length; i++)
            {
                if (rollSum > 0)
                {
                    rollSum += arr[i];
                }
                else
                {
                    rollSum = arr[i];
                }
                if (rollSum > rollMax)
                {
                    rollMax = rollSum;
                }
            }
            if (rollMax <= k)
            {
                return rollMax;
            }
            int max = int.MinValue;
            for (int l = 0; l < arr.Length; l++)
            {
                int sum = 0;
                for (int r = l; r < arr.Length; r++)
                {
                    sum += arr[r];
                    if (sum > max && sum <= k)
                    {
                        max = sum;
                    }
                    if (max == k)
                    {
                        return k;
                    }
                }
            }

            return max;
        }
    }
}
