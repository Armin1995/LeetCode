using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 数对和
/// </summary>
namespace Interview16._24
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public IList<IList<int>> PairSums(int[] nums, int target)
        {
            if (nums == null)
            {
                return null;
            }
            nums = nums.OrderBy(o => o).ToArray();
            List<IList<int>> result = new List<IList<int>>();
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    result.Add(new List<int>() { nums[left], nums[right] });
                    left++;
                    right--;
                }
            }
            return result;
        }
    }
}
