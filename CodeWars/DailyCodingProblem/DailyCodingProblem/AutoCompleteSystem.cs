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
            InsertBasicData();
        }

        private void InsertBasicData()
        {
            Insert("dog");
            Insert("deer");
            Insert("deal");
        }

        public string[] GetByKey(string key)
        {
            List<string> list = new List<string>();
            int index;
            TrieNode lastNode = root;

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < key.Length; i++)
            {
                index = key[i] - 'a';

                lastNode = lastNode.Children[index];

                if (lastNode.Children == null)
                {
                    return list.ToArray();
                }
                stringBuilder.Append((char)(index + 'a'));
            }
            return list.ToArray();
        }

        private void Suggest(TrieNode lastNode, List<string> list, StringBuilder key)
        {
            if (lastNode.IsWordEnd) list.Add(key.ToString());

            if (lastNode.Children == null) return;

            for(int i = 0; i < lastNode.Children.Count(); i++)
            {
                if (lastNode.Children[i] == null) continue;

                char c = (char)(i + 'a');

                Suggest(lastNode.Children[i], list, key.Append(c));

                key.Length--;
            }
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
                index = key[i] - 'a';//subtract this convert to int and change from ascii values to start from 0 to 26

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
    //TODO: Create Dictionary from for example csv and watch autocomplete algo on youtube
}
