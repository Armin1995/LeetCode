using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 12. 整数转罗马数字
/// </summary>
namespace LeetCode12
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var r = s.IntToRoman(39);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }


    public class Solution
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, string> romanDict = new Dictionary<int, string>()
            {
                { 1,"I" },
                { 2,"II" },
                { 3,"III" },
                { 4,"IV" },
                { 5,"V" },
                { 6,"VI" },
                { 7,"VII" },
                { 8,"VIII" },
                { 9,"IX" },
                { 10,"X" },
                { 20,"XX" },
                { 30,"XXX" },
                { 40,"XL" },
                { 50,"L" },
                { 60,"LX" },
                { 70,"LXX" },
                { 80,"LXXX" },
                { 90,"XC" },
                { 100,"C" },
                { 200,"CC" },
                { 300,"CCC" },
                { 400,"CD" },
                { 500,"D" },
                { 600,"DC" },
                { 700,"DCC" },
                { 800,"DCCC" },
                { 900,"CM" },
                { 1000,"M" },
                { 2000,"MM" },
                { 3000,"MMM" },
            };
            var q = num / 1000;
            num -= 1000 * q;
            var b = num / 100;
            num -= 100 * b;
            var s = num / 10;
            num -= 10 * s;
            var g = num;
            StringBuilder stringBuilder = new StringBuilder();
            if (q != 0)
            {
                stringBuilder.Append(romanDict[q * 1000]);
            }
            if (b != 0)
            {
                stringBuilder.Append(romanDict[b * 100]);
            }
            if (s != 0)
            {
                stringBuilder.Append(romanDict[s * 10]);
            }
            if (g != 0)
            {
                stringBuilder.Append(romanDict[g]);
            }

            return stringBuilder.ToString();
        }
    }
}
