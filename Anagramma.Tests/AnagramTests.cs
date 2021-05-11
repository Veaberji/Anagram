using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Anagramma.Tests
{
    [TestClass]
    public class AnagramTests
    {

        [TestMethod]
        public void Reverse_OneWord_OneWordReversed()
        {
            string word = "oneWord";
            string expected = "droWeno";

            string actual = Anagram.Reverse(word);

            Assert.AreEqual(expected, actual); ;
        }


        [TestMethod]
        public void Reverse_TwoWordsWhitsSymbolsAndNumbers_TwoWordsReversedWhitsSymbolsAndNumbersOnSamePositions()
        {
            string words = "  a12bc+d    efg!h";
            string expected = "  d12cb+a    hgf!e";

            string actual = Anagram.Reverse(words);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Reverse_Null_FailToReverse()
        {
            Anagram.Reverse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Reverse_EmptyString_FailToReverse()
        {
            Anagram.Reverse("");
        }
    }
}
