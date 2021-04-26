using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1011
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int ShipWithinDays(int[] weights, int D)
        {
            int minWeight = weights.Max();
            var sum = weights.Sum();
            while (minWeight * D < sum)
            {
                minWeight++;
            }



            if (turns <= D)
            {
                return minWeight;
            }
            else
            {
                minWeight++;
            }

            return minWeight;
        }

        private int GetTurns(int[] weights, int minWeight)
        {
            int turns = 0;
            int curWeight = 0;
            int index = 0;
            while (index < weights.Length && curWeight <= minWeight)
            {
                curWeight += weights[index];
                index++;
            }
            turns++;

            return turns;
        }
    }
}
