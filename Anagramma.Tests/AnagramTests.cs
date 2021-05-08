using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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

            var sr = new StringReader(word);
            Console.SetIn(sr);
            string actual = Anagram.Reverse();
            Assert.AreEqual(expected, actual); ;

        }


        [TestMethod]
        public void Reverse_TwoWordsWhitsSymbolsAndNumbers_TwoWordsReversedWhitsSymbolsAndNumbersOnSamePositions()
        {
            string words = "  a12bc+d    efg!h";
            string expected = "  d12cb+a    hgf!e";

            var sr = new StringReader(words);
            Console.SetIn(sr);
            string actual = Anagram.Reverse();
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Reverse_Null_FailToReverse()
        {
            var sr = new StringReader(null);
            Console.SetIn(sr);
            Anagram.Reverse();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Reverse_EmptyString_FailToReverse()
        {
            var sr = new StringReader("");
            Console.SetIn(sr);
            Anagram.Reverse();
        }
    }
}
