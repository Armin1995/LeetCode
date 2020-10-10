using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode754
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            var sum = 0;
            var result = 0;
            while (sum < target)
            {
                result++;
                sum += result;
            }
            var delta = sum - target;
            if (delta % 2 == 0)
            {
                return result;
            }
            else
            {
                if (result % 2 == 0)
                {
                    return result + 1;
                }
                else
                {
                    return result + 2;
                }
            }
        }
    }
}
