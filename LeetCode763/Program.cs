using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode763
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var list = s.PartitionLabels("ababcbacadefegdehijhklij");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<int> PartitionLabels(string S)
        {
            List<string> strList = new List<string>();
            for (int i = 0; i < S.Length; i++)
            {
                var c = S[i];
                bool isContain = false;
                for (int j = 0; j < strList.Count; j++)
                {
                    var str = strList[j];
                    if (str.Contains(c))
                    {
                        strList[j] = CombimeStr(strList, j, c);
                        isContain = true;
                        break;
                    }
                }
                if (!isContain)
                {
                    strList.Add(c.ToString());
                }
            }
            return strList.ConvertAll(o => o.Length);
        }

        private string CombimeStr(List<string> strList, int j, char c)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = j; i < strList.Count; i++)
            {
                stringBuilder.Append(strList[i]);
            }
            stringBuilder.Append(c);
            for (int i = strList.Count - 1; i > j; i--)
            {
                strList.RemoveAt(i);
            }
            return stringBuilder.ToString();
        }
    }
}
