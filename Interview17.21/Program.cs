using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 面试题 17.21. 直方图的水量
/// </summary>
namespace Interview17._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            Solution s = new Solution();
            var r = s.Trap(height);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Trap(int[] height)
        {
            int result = 0;

            int left = GetLeft(height, 0, height.Length - 1);

            int right = GetRight(height, 0, height.Length - 1);

            while (left != right)
            {
                for (int i = left; i <= right; i++)
                {
                    if (height[i] <= 0)
                    {
                        result++;
                    }
                    height[i]--;
                }
                var l = GetLeft(height, left, right);
                var r = GetRight(height, left, right);
                left = l;
                right = r;
            }

            return result;
        }

        public int GetLeft(int[] height, int l, int r)
        {
            int left = -1;
            for (int i = l; i <= r; i++)
            {
                if (height[i] > 0)
                {
                    left = i;
                    break;
                }
            }

            return left;
        }

        public int GetRight(int[] height, int l, int r)
        {
            int right = -1;
            for (int i = r; i >= l; i--)
            {
                if (height[i] > 0)
                {
                    right = i;
                    break;
                }
            }

            return right;
        }
    }
}
