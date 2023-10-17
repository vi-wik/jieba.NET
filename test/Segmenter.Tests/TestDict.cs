using System;
using System.IO;
using JiebaNet.Segmenter.Common;
using NUnit.Framework;

namespace JiebaNet.Segmenter.Tests
{
    [TestFixture]
    public class TestDict
    {
        [TestCase]
        public void TestMainDictStream()
        {
            var mainDict = ConfigManager.OpenMainDictFile().ReadAllTextThenDispose();
            Assert.That(mainDict, Is.Not.Empty);
        }

        [TestCase]
        public void TestDictTrie()
        {
            var dict = WordDictionary.Instance;
            Console.WriteLine(dict.Trie.Count);
            Console.WriteLine(dict.Total);
        }
    }
}