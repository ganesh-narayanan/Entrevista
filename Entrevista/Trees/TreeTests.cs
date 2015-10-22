// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeTests.cs" company="">
//   
// </copyright>
// <summary>
//   The tree tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Trees
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Trees.Implementations;

    /// <summary>The tree tests.</summary>
    [TestClass]
    public class TreeTests
    {
        /// <summary>The test TRIE.</summary>
        [TestMethod]
        public void TestTrie()
        {
            string[] arrayOfWords =
                "antagonist, antecedent, antidisestablishmentarianism, antimicrobial, antonym, antonyms, apathy, aphorism, apologize, appendices, appreciate, apropos, arbitrary, arcane, archetype, arrogant, articulate, as, ascites, ascot, ask, assimilation, astute, asymmetry, attribution, attrition, auspicious, austere, autonomy, auxiliary, avarice, avid, awesome, addicting, adjective, adverbs, aesthetician, anarchy, andragogy, antebellum, aperture, appendix, array, art, atelectasis"
                    .Split(',');
            Trie trie = new Trie();
            trie.CreateTrie(arrayOfWords);
            Assert.AreEqual(trie.IsWord("Ganesh"), false);
            Assert.AreEqual(trie.IsWord("antagonist"), true);
        }
    }
}