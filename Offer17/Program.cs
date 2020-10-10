using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offer17
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] PrintNumbers(int n)
        {
            int count = (int)Math.Pow(10, n) - 1;
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
    }
}
