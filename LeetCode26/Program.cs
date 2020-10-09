using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode26
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 4, 4, 4, 5 };
            Solution solution = new Solution();
            var result = solution.RemoveDuplicates(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[result - 1] > nums[i])
                    {
                        continue;
                    }
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] > nums[i])
                        {
                            result++;
                            if (j != i + 1)
                            {
                                nums[i + 1] = nums[j];
                            }
                            break;
                        }
                    }
                }
                return result;
            }
        }
    }
}
