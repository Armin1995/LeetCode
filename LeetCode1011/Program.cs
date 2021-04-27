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
            Solution s = new Solution();

            int[] weights = new int[] { 10, 9, 5, 11, 6, 7 };

            s.ShipWithinDays(weights, 1);
        }
    }

    public class Solution
    {
        public int ShipWithinDays(int[] weights, int D)
        {
            int minWeight = weights.Max();
            int maxWeight = weights.Sum();

            while (minWeight < maxWeight)
            {
                int mid = (minWeight + maxWeight) / 2;
                var turn = GetTurns(weights, mid);
                if (turn <= D)
                {
                    maxWeight = mid;
                }
                else
                {
                    minWeight = mid + 1;
                }
            }

            return minWeight;
        }

        private int GetTurns(int[] weights, int perTurnWeight)
        {
            int turns = 0;
            int curWeight = 0;
            int index = 0;
            while (index < weights.Length)
            {
                var tempWeight = curWeight + weights[index];
                if (tempWeight > perTurnWeight)
                {
                    turns++;
                    curWeight = weights[index];
                }
                else
                {
                    curWeight += weights[index];
                }
                index++;
            }

            return turns + 1;
        }
    }
}
