using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 208. 实现 Trie (前缀树)
/// </summary>
namespace LeetCode208
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie obj = new Trie();
            obj.Insert("apple");
            bool param_2 = obj.Search("app");
            bool param_3 = obj.StartsWith("apple");
        }
    }

    public class Trie
    {
        private Trie[] children;
        private bool isEnd;
        /** Initialize your data structure here. */
        public Trie()
        {
            children = new Trie[26];
            isEnd = false;
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            Trie node = this;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                int index = c - 'a';
                if (node.children[index] == null)
                {
                    node.children[index] = new Trie();
                }
                node = node.children[index];
            }
            node.isEnd = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            Trie node = SearchPrefix(word);
            return node != null && node.isEnd;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            Trie node = SearchPrefix(prefix);
            return node != null;
        }

        private Trie SearchPrefix(string prefix)
        {
            Trie node = this;
            for (int i = 0; i < prefix.Length; i++)
            {
                var c = prefix[i];
                int index = c - 'a';
                if (node.children[index] == null)
                {
                    return null;
                }
                node = node.children[index];
            }
            return node;
        }
    }
}
