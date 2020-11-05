using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 单词接龙
/// </summary>
namespace LeetCode127
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var beginWord = "talk";
            var endWord = "tail";
            List<string> wordList = new List<string>() { "talk", "tons", "fall", "tail", "gale", "hall", "negs", "tall" };

            Console.WriteLine(s.LadderLength(beginWord, endWord, wordList));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int len = wordList.Count;
            int wordLength = wordList[0].Length;

            // 看看endWord存不存在
            if (!wordList.Contains(endWord))
                return 0;

            // endWord存在，准备参数
            int result = 1;
            int inIndex = 1;
            int outIndex = 0;
            List<string> words = new List<string>();
            words.Add(beginWord);
            int neighborCount = 1;
            int oldpig = 0;
            bool[] isVisited = new bool[len];

            // bfs循环
            while (inIndex > outIndex)
            {
                for (int i = 0; i < neighborCount; i++)
                {
                    if (words[outIndex] == endWord)
                    {
                        return result;
                    }
                    for (int j = 0; j < len; j++)
                    {
                        if (!isVisited[j] && isNeighbor(words[outIndex], wordList[j], wordLength))
                        {
                            words.Add(wordList[j]);
                            inIndex++;
                            isVisited[j] = true;
                            oldpig++;
                        }
                    }
                    outIndex++;
                }
                neighborCount = oldpig;
                oldpig = 0;
                result++;
            }
            return 0;
        }

        public bool isNeighbor(string hostWord, string testWord, int wordLength)
        {
            int difference = 0;
            for (int i = 0; i < wordLength; i++)
            {
                if (hostWord[i] != testWord[i])
                    difference++;
                if (difference > 1)
                    return false;
            }
            if (difference == 1)
                return true;
            return false;
        }
    }
}
