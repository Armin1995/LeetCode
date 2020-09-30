using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode848
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public string ShiftingLetters(string S, int[] shifts)
        {
            int times = 0;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = shifts.Length - 1; i >= 0; i--)
            {
                times = (times + shifts[i]) % 26;
                stringBuilder.Append(Shift(S[i], times));
            }
            return new string(stringBuilder.ToString().Reverse().ToArray());
        }

        public char Shift(char c, int times)
        {
            var num = (int)c;
            num += times;
            if (num > 122)
            {
                num -= 26;
            }
            return (char)num;
        }
    }
}
