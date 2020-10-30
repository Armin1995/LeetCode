using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 岛屿的周长
/// </summary>
namespace LeetCode463
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            var landCount = 0;
            var linkCount = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        landCount++;

                        if (i != grid.Length - 1)
                        {
                            if (grid[i][j] == grid[i + 1][j])
                            {
                                linkCount++;
                            }
                        }

                        if (j != grid[i].Length - 1)
                        {
                            if (grid[i][j] == grid[i][j + 1])
                            {
                                linkCount++;
                            }
                        }
                    }
                }
            }
            return landCount * 4 - linkCount * 2;
        }
    }
}
