using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode679
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool is24 = solution.JudgePoint24(new int[] { 1, 2, 1, 2 });
            Console.WriteLine(is24);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool JudgePoint24(int[] nums)
        {
            if (nums == null || nums.Length != 4 || nums.Any(o => o == 0))
            {
                return false;
            }

            var doubleNums = new double[nums.Length];
            nums.ToList().ConvertAll(o => (double)o).CopyTo(doubleNums);
            return AX2(doubleNums);
        }

        public bool AX2(double[] nums)
        {
            var is24 = false;

            for (int i = 0; i < nums.Length; i++)
            {
                var a = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    var b = nums[j];
                    foreach (var result in GetResultList(a, b))
                    {
                        double[] newArray = new double[nums.Length - 1];
                        newArray[0] = result;
                        if (newArray.Length == 1)
                        {
                            if (Math.Abs(newArray[0] - 24) < 0.01d)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            int index = 0;
                            for (int k = 0; k < nums.Length; k++)
                            {
                                if (k == i || k == j)
                                {
                                    continue;
                                }
                                index++;
                                newArray[index] = nums[k];
                            }
                            is24 = AX2(newArray);
                            if (is24)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public List<double> GetResultList(double a, double b)
        {
            return new List<double>() { a + b, a - b, a * b, a / b };
        }
    }
}
