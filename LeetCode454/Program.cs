using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode454
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Solution
        {
            public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < B.Length; j++)
                    {
                        var key = A[i] + B[j];
                        if (dict.ContainsKey(A[i] + B[j]))
                        {
                            dict[key]++;
                        }
                        else
                        {
                            dict.Add(key, 1);
                        }
                    }
                }

                int result = 0;

                for (int i = 0; i < C.Length; i++)
                {
                    for (int j = 0; j < D.Length; j++)
                    {
                        var key = -(C[i] + D[j]);
                        if (dict.ContainsKey(key))
                        {
                            result += dict[key];
                        }
                    }
                }

                return result;
            }
        }
    }
}
