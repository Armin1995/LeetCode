using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode406
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            if (people == null || people.Length == 0)
            {
                return null;
            }
            people = people.OrderByDescending(o => o.First()).ToArray();


        }


    }
}
