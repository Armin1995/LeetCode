using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 90. 子集 II
/// </summary>
namespace LeetCode90
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 2 };
            Solution s = new Solution();
            var result = s.SubsetsWithDup(array);
            foreach (var r in result)
            {
                var str = "";
                foreach (var b in r)
                {
                    str += "[" + b + "],";
                }
                str = str.TrimEnd(',');
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        private IList<IList<int>> ans;
        private bool[] visited;

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            ans = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
            {
                return ans;
            }

            visited = new bool[nums.Length];
            Array.Sort(nums);
            Backtrack(nums, new List<int>(), 0);
            return ans;
        }

        public void Backtrack(int[] nums, List<int> path, int start)
        {
            ans.Add(new List<int>(path));
            // 选择列表
            for (int i = start; i < nums.Length; i++)
            {
                if (i > 0 && !visited[i - 1] && nums[i] == nums[i - 1])
                {      // 剪枝
                    continue;
                }
                path.Add(nums[i]);
                visited[i] = true;
                Backtrack(nums, path, i + 1);
                path.RemoveAt(path.Count - 1);
                visited[i] = false;
            }
        }
    }
}
