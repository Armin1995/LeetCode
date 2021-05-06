using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1720. 解码异或后的数组
/// 0 ^ 0 = 0
/// 0 ^ 1 = 1
/// 1 ^ 0 = 1
/// 1 ^ 1 = 0
/// X ^ 0 = X
/// X ^ X = 0
/// </summary>
namespace LeetCode1720
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] encoded = new int[] { 1, 2, 3 };
            int first = 1;

            Solution s = new Solution();
            var arr = s.Decode(encoded, first);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] Decode(int[] encoded, int first)
        {
            //encoded[i] = arr[i] XOR arr[i + 1]
            //encoded[i - 1] = arr[i - 1] XOR arr[i]
            //encoded[i - 1] XOR arr[i - 1] = arr[i - 1] XOR arr[i] XOR arr[i - 1]
            //encoded[i - 1] XOR arr[i - 1] = (arr[i - 1] XOR arr[i - 1]) XOR arr[i]
            //encoded[i - 1] XOR arr[i - 1] = 0 XOR arr[i]
            //encoded[i - 1] XOR arr[i - 1] = arr[i]
            int[] arr = new int[encoded.Length + 1];
            arr[0] = first;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = encoded[i - 1] ^ arr[i - 1];
            }
            return arr;
        }
    }
}
