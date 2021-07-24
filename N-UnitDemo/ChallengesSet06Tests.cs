using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet06Tests
    {
        private ChallengesSet06 _set06;

        [SetUp]
        public void Setup()
        {
            _set06 = new ChallengesSet06();
        }

        [TestCase(new string[] { "alpha", "bravo", "charlie" }, "alpha", true, true)]
        [TestCase(new string[] { "alpha", "bravo", "charlie" }, "alpha", false, true)]
        [TestCase(new string[] { "alpha", "bravo", "charlie" }, "bravo", true, true)]
        [TestCase(new string[] { "alpha", "bravo", "charlie" }, "charlie", true, true)]
        [TestCase(new string[] { "Alpha", "bravo", "charlie" }, "alpha", true, true)]
        [TestCase(new string[] { "Alpha", "braVo", "charlie" }, "bravo", true, true)]
        [TestCase(new string[] { "Alpha", "bravo", "chArlie" }, "charlie", true, true)]
        [TestCase(new string[] { "AlPha", "alpha", "bravo", "charlie" }, "alpha", false, true)]
        [TestCase(new string[] { "AlPha", "bravo", "charlie" }, "alpha", false, false)]
        [TestCase(new string[] { "alpha", "bravo", "charlie" }, "delta", true, false)]
        [TestCase(new string[] { null, "bravo", "charlie" }, "braVo", false, false)]
        [TestCase(new string[] { null, "bravo", "chArlie" }, "charliE", false, false)]
        [TestCase(new string[] { null, null, "charlie" }, "bravo", true, false)]
        [TestCase(null, "alpha", true, false)]
        public void CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase, bool expected)
        {
            var actual = _set06.CollectionContainsWord(words, word, ignoreCase);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(1523, true)]
        [TestCase(26357, true)]
        [TestCase(37117, true)]
        [TestCase(83791, true)]
        [TestCase(91199, true)]
        [TestCase(91387, true)]
        [TestCase(91909, true)]
        [TestCase(99991, true)]
        [TestCase(1, false)]
        [TestCase(4, false)]
        [TestCase(2000, false)]
        [TestCase(10011, false)]
        [TestCase(99561, false)]
        [TestCase(99987, false)]
        [TestCase(0, false)]
        [TestCase(-1, false)]
        [TestCase(-5, false)]
        [TestCase(-101, false)]
        [TestCase(-99991, false)]
        public void IsPrimeNumber(int number, bool expected)
        {
            var actual = _set06.IsPrimeNumber(number);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("aaaa", -1)]
        [TestCase("aaa", -1)]
        [TestCase("aa", -1)]
        [TestCase("a", 0)]
        [TestCase("", -1)]
        [TestCase("ab", 1)]
        [TestCase("abb", 0)]
        [TestCase("aba", 1)]
        [TestCase("aab", 2)]
        [TestCase("aabaa", 2)]
        [TestCase("aabbc", 4)]
        [TestCase("aabcc", 2)]
        [TestCase("aabbcddee", 4)]
        [TestCase("aaabbbcdddeee", 6)]
        [TestCase("aaabbbcdddeeeffg", 15)]
        [TestCase("abbbccdddeeeffgg", 0)]
        public void LastUniqueIndex(string str, int expected)
        {
            var actual = _set06.IndexOfLastUniqueLetter(str);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 2, 3, 4, 5 }, 2)]
        [TestCase(new int[] { 10, 3, 1, 1, 1, 5, 1 }, 3)]
        [TestCase(new int[] { 1, 2, 2, 3, 3, 3, 3, 2, 5 }, 4)]
        [TestCase(new int[] { 1, 2, 2, 3, 3, 3, 3 }, 4)]
        [TestCase(new int[] { 1, 2, 2, 3, 2 }, 2)]
        [TestCase(new int[] { 3, 3, 3, 2, 2 }, 3)]
        [TestCase(new int[] { 1, 3, 2, 3, 3, 3, 3 }, 4)]
        public void MaxConsecutiveCount(int[] numbers, int expected)
        {
            var actual = _set06.MaxConsecutiveCount(numbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 4, new[] { 4d, 8, 12, 16 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 3, new[] { 3d, 6, 9, 12, 15 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 2, new[] { 2d, 4, 6, 8, 10, 12, 14, 16 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5 }, 1, new[] { 1d, 2, 3, 4, 5 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 8, new[] { 8d, 16 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 10, new[] { 10d })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 20, new double[] { })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, -2, new double[] { })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 4, new[] { 4d, 8, 12 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 4, new[] { 4d, 8 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7 }, 4, new[] { 4d })]
        [TestCase(new[] { 1d }, 1, new[] { 1d })]
        [TestCase(new[] { 1d }, -1, new double[] { })]
        [TestCase(new double[] { }, 0, new double[] { })]
        [TestCase(new double[] { }, 1, new double[] { })]
        [TestCase(null, 0, new double[] { })]
        [TestCase(null, 1, new double[] { })]
        public void GetEveryNthElement_List(double[] numbers, int n, double[] expected)
        {
            // Arrange
            var numbersAsList = numbers == null ? null : new List<double>(numbers);

            // Act
            var actual = _set06.GetEveryNthElement(numbersAsList, n);

            //Assert
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(Math.Round(expected[i], 4), Math.Round(actual[i], 4));
            }
        }
    }
}
