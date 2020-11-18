using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode134
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gas = new int[] { 2, 3, 4 };
            int[] cost = new int[] { 3, 4, 3 };

            Solution s = new Solution();
            Console.WriteLine(s.CanCompleteCircuit(gas, cost));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            for (int i = 0; i < gas.Length; i++)
            {
                var newGas = new int[gas.Length + 1];
                var newCost = new int[gas.Length + 1];
                for (int j = 0; j < newGas.Length; j++)
                {
                    newGas[j] = gas[(i + j) % gas.Length];
                    newCost[j] = cost[(i + j) % gas.Length];
                }
                if (CanCycle(newGas, newCost))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool CanCycle(int[] gas, int[] cost)
        {
            var oil = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                oil += gas[i];
                if (oil < cost[i])
                {
                    return false;
                }
                oil -= cost[i];
            }
            return true;
        }
    }
}
