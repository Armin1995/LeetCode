using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 81. 搜索旋转排序数组 II
/// </summary>
namespace LeetCode81
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 5, 6, 0, 0, 1, 2 };
            Solution s = new Solution();
            var r = s.Search(nums, 3);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool Search(int[] nums, int target)
        {
            int n = nums.Length;

            if (n == 0)
            {
                return false;
            }

            if (n == 1)
            {
                return nums[0] == target;
            }

            int l = 0, r = n - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (nums[mid] == target)
                {
                    return true;
                }

                if (nums[mid] == nums[l] && nums[mid] == nums[r])
                {
                    l++;
                    r--;
                }
                else if (nums[mid] >= nums[l])
                {
                    if (target >= nums[l] && target < nums[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                else
                {
                    if (target <= nums[r] && target > nums[mid])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }

            }

            return false;
        }
    }
}
