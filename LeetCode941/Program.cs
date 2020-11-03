using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 有效的山脉数组
/// </summary>
namespace LeetCode941
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A == null || A.Length < 3)
            {
                return false;
            }
            int left = 0;
            int right = A.Length - 1;
            while (left < right && A[left] < A[left + 1])
            {
                left++;
            }

            if (left == 0 || left == right)
            {
                return false;
            }

            while (left < right && A[left] > A[left + 1])
            {
                left++;
            }

            return left == right;
        }
    }
}
