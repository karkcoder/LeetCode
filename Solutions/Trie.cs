using System.Collections.Generic;

namespace Solutions
{
    //Problem 208 Implementing trie https://leetcode.com/problems/implement-trie-prefix-tree/
    public class TrieNode
    {
        public Dictionary<char, TrieNode> childrenMap { get; set; }
        public bool isWord { get; set; }

        public TrieNode()
        {
            childrenMap = new Dictionary<char, TrieNode>();
            isWord = false;
        }
    }

    public class Trie
    {
        private TrieNode _root;

        public Trie()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            var cur = _root;
            foreach (char c in word)
            {
                if (!cur.childrenMap.ContainsKey(c))
                {
                    cur.childrenMap[c] = new TrieNode();
                }
                cur = cur.childrenMap[c];
            }
            cur.isWord = true;
        }

        public bool Search(string word)
        {
            var node = Traverse(word);
            return node != null && node.isWord;
        }

        public bool StartsWith(string prefix)
        {
            var node = Traverse(prefix);
            return node != null;
        }

        private TrieNode Traverse(string path)
        {
            var cur = _root;
            foreach (var c in path)
            {
                if (cur.childrenMap.ContainsKey(c))
                {
                    cur = cur.childrenMap[c];
                }
                else
                {
                    return null;
                }
            }
            return cur;
        }
    }
}