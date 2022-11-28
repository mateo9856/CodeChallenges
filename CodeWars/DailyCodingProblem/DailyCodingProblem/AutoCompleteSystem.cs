using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class AutoCompleteSystem
    {
        static TrieNode root;
        public AutoCompleteSystem()
        {
            root = new TrieNode();
        }
        public void Insert(string key) 
        {//i = level, key.Length = length

            int index;

            TrieNode pCrawl = root;

            for(int i = 0; i < key.Length; i++)
            {
                index = key[i] - 'a';

                if(pCrawl.Children[index] == null)
                    pCrawl.Children[index] = new TrieNode();

                pCrawl = pCrawl.Children[index];
            }

            pCrawl.IsWordEnd = true;

        }

        public bool Search(string key)
        {
            int index;
            TrieNode pCrawl = root;

            for (int i = 0; i < key.Length; i++)
            {
                index = key[i] - 'a';

                if (pCrawl.Children[index] == null)
                    return false;

                pCrawl = pCrawl.Children[index];
            }

            return (pCrawl.IsWordEnd);

        }
    }

    public class TrieNode
    {
        public const int ALPHABET_SIZE = 26;
        public TrieNode[] Children = new TrieNode[ALPHABET_SIZE];
        public bool IsWordEnd { get; set; }

        public TrieNode()
        {
            IsWordEnd = false;
            for (int i = 0; i < ALPHABET_SIZE; i++)
                Children[i] = null;
        }
    }

}
