using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 368. 最大整除子集
/// </summary>
namespace LeetCode368
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 5, 6, 9 };
            Solution s = new Solution();
            var r = s.LargestDivisibleSubset(nums);
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);
            //从零开始至 nums 下标为 i 的元素，可以形成长度为 subsetLength[i] 整除的子集
            int[] subsetLength = new int[nums.Length];
            //能取得最大子集的元素下标
            //所以 nums[maxIndex] 为子集的最大元素
            //subsetLength[maxIndex] 为子集的长度
            int maxIndex = 0;
            //计算以当前元素为最大元素，能取得多大的子集
            for (int i = 0; i < nums.Length; i++)
            {
                subsetLength[i] = 1;//每个元素必然至少与自己形成一个子集
                                    //最大元素（ nums[i] ）之前的元素
                for (int j = 0; j < i; j++)
                {
                    //如果之前的元素 nums[j] 能整除其最大元素 nums[i] 
                    //说明，nums[j] 之前的元素也必然能整除 nums[i]
                    //而 subsetLength[j] 表示以 nums[j] 为最大元素能取得的子集长度
                    //故相加即可
                    if (nums[i] % nums[j] == 0)
                        subsetLength[i] = Math.Max(subsetLength[i], subsetLength[j] + 1);
                }
                if (subsetLength[i] > subsetLength[maxIndex])
                    maxIndex = i;
            }
            //根据已取得的 最大子集中的最大元素（maxNum）和其长度 maxLength 推导出最大子集
            List<int> maxSubset = new List<int>();
            //先把最大元素加进去
            maxSubset.Add(nums[maxIndex]);
            for (int i = nums.Length - 1; i >= 0 && subsetLength[maxIndex] > 1; i--)
                if (subsetLength[maxIndex] - 1 == subsetLength[i] && nums[maxIndex] % nums[i] == 0)
                {
                    maxSubset.Add(nums[i]);
                    maxIndex = i;
                }
            return maxSubset;
        }
    }
}
