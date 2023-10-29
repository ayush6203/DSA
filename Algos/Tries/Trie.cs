using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Tries
{
    public class Trie
    {
        TrieNode root = null;
        public void Insert(string input)
        {
            if(root == null)
                root = new TrieNode();

            InsertInput(root, input, 0);
        }

        public bool Search(string input)
        {
            TrieNode node = root;
            if (node == null)
                return false;

            foreach(char ch in input)
            {
                if (node._nodes[ch - 'a'] == null)
                    return false;

                node = node._nodes[ch - 'a'];
            }

            return !node._flag;
        }

        public bool StartsWith(string input)
        {
            TrieNode node = root;

            if (node == null)
                return false;

            foreach (char ch in input)
            {
                if (node._nodes[ch - 'a'] == null)
                    return false;

                node = node._nodes[ch - 'a'];
            }

            return true;
        }

        private void InsertInput(TrieNode node, string input, int index)
        {
            if(index == input.Length - 1)
            {
                node._nodes[input[index] - 'a'] = new TrieNode(false);
                return;
            }


            if (node._nodes[input[index] - 'a'] == null)
                node._nodes[input[index] - 'a'] = new TrieNode();

            InsertInput(node._nodes[input[index] - 'a'], input, index + 1);
        }
    }

    public class TrieNode
    {
        public TrieNode[] _nodes;
        public bool _flag;

        public TrieNode(bool flag = true)
        {
            _nodes = new TrieNode[26];
            _flag = flag;
        }
    }
}
