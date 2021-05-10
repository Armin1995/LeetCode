using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1723
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] jobs = new int[] { 1, 2, 4, 7, 8 };
            int k = 2;

            var r = s.MinimumTimeRequired(jobs, k);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MinimumTimeRequired(int[] jobs, int k)
        {
            Array.Sort(jobs);
            Array.Reverse(jobs);
            int l = jobs[0], r = jobs.Sum();
            while (l < r)
            {
                int mid = (l + r) >> 1;
                if (Check(jobs, k, mid))
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }

        public bool Check(int[] jobs, int k, int limit)
        {
            int[] workloads = new int[k];
            return Backtrack(jobs, workloads, 0, limit);
        }

        public bool Backtrack(int[] jobs, int[] workloads, int i, int limit)
        {
            if (i >= jobs.Length)
            {
                return true;
            }
            int cur = jobs[i];
            for (int j = 0; j < workloads.Length; ++j)
            {
                if (workloads[j] + cur <= limit)
                {
                    workloads[j] += cur;
                    if (Backtrack(jobs, workloads, i + 1, limit))
                    {
                        return true;
                    }
                    workloads[j] -= cur;
                }
                // 如果当前工人未被分配工作，那么下一个工人也必然未被分配工作
                // 或者当前工作恰能使该工人的工作量达到了上限
                // 这两种情况下我们无需尝试继续分配工作
                if (workloads[j] == 0 || workloads[j] + cur == limit)
                {
                    break;
                }
            }
            return false;
        }
    }
}
