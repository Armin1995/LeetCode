using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1002
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public IList<string> CommonChars(string[] A)
        {
            IList<string> result = new List<string>();
            if (A.Length == 0)
            {
                return result;
            }
            else if (A.Length == 1)
            {
                return A.ToList();
            }
            else
            {
                Dictionary<char, int> charTimesDict = new Dictionary<char, int>();
                var first = A[0].ToList().Distinct();
                foreach (var ch in first)
                {
                    int minTimes = int.MaxValue;
                    if (A.All(o => o.Contains(ch)))
                    {
                        foreach (var str in A)
                        {
                            int times = 0;
                            foreach (var c in str)
                            {
                                if (c == ch)
                                {
                                    times++;
                                }
                            }
                            if (times < minTimes)
                            {
                                minTimes = times;
                            }
                        }
                        charTimesDict.Add(ch, minTimes);
                    }
                }
                foreach (var kv in charTimesDict)
                {
                    for (int i = 0; i < kv.Value; i++)
                    {
                        result.Add(kv.Key.ToString());
                    }
                }
                return result;
            }
        }
    }
}
