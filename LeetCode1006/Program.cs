using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1006
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var r = s.Clumsy(12);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Clumsy(int N)
        {
            List<int> results = new List<int>();
            var count = 4;
            var ints = new List<int>();
            while (N > 0)
            {
                ints.Add(N);
                count--;
                if (N == 1)
                {
                    count = 4;
                    results.Add(Cal3(ints));
                    ints.Clear();
                }
                else
                {
                    if (count == 1)
                    {
                        results.Add(Cal3(ints));
                        ints.Clear();
                    }
                    else if (count == 0)
                    {
                        count = 4;
                        results.Add(Cal3(ints));
                        ints.Clear();
                    }
                }
                N--;
            }

            return Sub(results);
        }

        public int Cal3(List<int> ints)
        {
            int result = 0;
            if (ints.Count == 3)
            {
                result = ints[0] * ints[1] / ints[2];
            }
            else if (ints.Count == 2)
            {
                result = ints[0] * ints[1];
            }
            else if (ints.Count == 1)
            {
                result = ints[0];
            }
            return result;
        }

        public int Sub(List<int> ints)
        {
            if (ints.Count == 0)
            {
                return 0;
            }
            var result = ints.First();
            for (int i = 1; i < ints.Count; i++)
            {
                if (i % 2 == 0)
                {
                    result = result - ints[i];
                }
                else
                {
                    result = result + ints[i];
                }
            }

            return result;
        }
    }
}
