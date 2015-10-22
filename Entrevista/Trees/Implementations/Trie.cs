// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Trie.cs" company="">
//   
// </copyright>
// <summary>
//   The trie.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Trees.Implementations
{
    using System.Collections.Generic;

    /// <summary>The TRIE.</summary>
    public class Trie
    {
        /// <summary>Initializes a new instance of the <see cref="Trie"/> class.</summary>
        public Trie()
        {
            this.Root = new TrieNode();
        }

        /// <summary>Gets or sets the root.</summary>
        public TrieNode Root { get; set; }

        /// <summary>The add.</summary>
        /// <param name="word">The word.</param>
        /// <param name="start">The start.</param>
        public void Add(string word, TrieNode start = null)
        {
            TrieNode current = start ?? this.Root;
            foreach (char c in word)
            {
                if (current?.Children != null && current.Children.ContainsKey(c))
                {
                    current.Children.TryGetValue(c, out current);
                }
                else
                {
                    TrieNode newNode = new TrieNode();
                    current?.Children?.Add(c, newNode);
                    current = newNode;
                }
            }

            if (current != null)
            {
                current.IsWord = true;
            }
        }

        /// <summary>The is word.</summary>
        /// <param name="word">The word.</param>
        /// <param name="start">The start.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsWord(string word, TrieNode start = null)
        {
            TrieNode current = this.GetNode(word, start);
            return current != null;
        }

        /// <summary>The get node.</summary>
        /// <param name="word">The word.</param>
        /// <param name="start">The start.</param>
        /// <returns>The <see cref="TrieNode"/>.</returns>
        private TrieNode GetNode(string word, TrieNode start = null)
        {
            TrieNode current = start ?? this.Root;
            foreach (char c in word)
            {
                if (current?.Children?.ContainsKey(c) == false)
                {
                    return null;
                }

                current = current?.Children?[c];
            }

            return current;
        }

        public void CreateTrie(string[] words, TrieNode start = null)
        {
            foreach (string word in words)
            {
                this.Add(word, start);
            }
        }

        /// <summary>The TRIE node.</summary>
        public class TrieNode
        {
            /// <summary>Initializes a new instance of the <see cref="TrieNode"/> class.</summary>
            public TrieNode()
            {
                this.Children = new Dictionary<char, TrieNode>();
            }

            /// <summary>Gets or sets the children.</summary>
            public Dictionary<char, TrieNode> Children { get; set; }

            /// <summary>Gets or sets a value indicating whether is word.</summary>
            public bool IsWord { get; set; }
        }
    }
}