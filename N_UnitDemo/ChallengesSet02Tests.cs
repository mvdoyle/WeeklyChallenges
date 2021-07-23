using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet02Tests
    {
        private ChallengesSet02 _set02;

        [SetUp]
        public void Setup()
        {
            _set02 = new ChallengesSet02();
        }

        [Test]
        public void CharacterIsALetter()
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (var letter in lowercaseAlphabet)
            {
                var lowercaseActual = _set02.CharacterIsALetter(letter);
                var uppercaseActual = _set02.CharacterIsALetter(char.ToUpper(letter));

                Assert.IsTrue(lowercaseActual);
                Assert.IsTrue(uppercaseActual);
            }
        }

        [Test]
        public void CharacterIsNotALetter()
        {
            string nonLetters = "0123456789`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?\u2222";

            foreach (var letter in nonLetters)
            {
                var actual = _set02.CharacterIsALetter(letter);
                Assert.IsFalse(actual);
            }
        }

        [TestCase(new string[] { }, true)]
        [TestCase(new string[] { "a", "b" }, true)]
        [TestCase(new string[] { "a", "b", "c", "d" }, true)]
        [TestCase(new string[] { "", "", "", "", "", "" }, true)]
        [TestCase(new string[] { "a" }, false)]
        [TestCase(new string[] { "a", "b", "c" }, false)]
        [TestCase(new string[] { "a", "b", "c", "d", "e" }, false)]
        // [InlineData(null, false)] // Assumption: array will not be null
        public void CountOfElementsIsEven(string[] strings, bool expected)
        {
            var actual = _set02.CountOfElementsIsEven(strings);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, true)]
        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(8, true)]
        [TestCase(-2, true)]
        [TestCase(-4, true)]
        [TestCase(1, false)]
        [TestCase(3, false)]
        [TestCase(5, false)]
        [TestCase(7, false)]
        [TestCase(-1, false)]
        [TestCase(-3, false)]
        public void IsNumberEven(int number, bool expected)
        {
            var actual = _set02.IsNumberEven(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, false)]
        [TestCase(2, false)]
        [TestCase(4, false)]
        [TestCase(6, false)]
        [TestCase(8, false)]
        [TestCase(-2, false)]
        [TestCase(-4, false)]
        [TestCase(1, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(-1, true)]
        [TestCase(-3, true)]
        public void IsNumberOdd(int number, bool expected)
        {
            var actual = _set02.IsNumberOdd(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 0 }, 0)]
        [TestCase(new double[] { 5 }, 10)]
        [TestCase(new double[] { 0, 0 }, 0)]
        [TestCase(new double[] { -5, 0 }, -5)]
        [TestCase(new double[] { 0, 5 }, 5)]
        [TestCase(new double[] { -5, 5 }, 0)]
        [TestCase(new double[] { -15.5, 1, -5, 8 }, -7.5)]
        [TestCase(new double[] { -2.7, 0, -2.3, 12, 9 }, 9.3)]
        [TestCase(new double[] { }, 0)]
        [TestCase(null, 0)]
        public void SumOfMinAndMax(IEnumerable<double> numbers, double expected)
        {
            var actual = _set02.SumOfMinAndMax(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hello", "world", 5)]
        [TestCase("abcde", "fghi", 4)]
        [TestCase("abc", "defg", 3)]
        [TestCase("abcd", "ef", 2)]
        [TestCase("a", "bc", 1)]
        [TestCase("a", "", 0)]
        public void GetLengthOfShortestString(string str1, string str2, int expected)
        {
            var actual = _set02.GetLengthOfShortestString(str1, str2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -15)]
        [TestCase(new int[] { 1, -2, 3, -4, 5 }, 3)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(null, 0)]
        public void Sum(int[] numbers, int expected)
        {
            var actual = _set02.Sum(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -6)]
        [TestCase(new int[] { 1, -2, 3, -4, 5 }, -6)]
        [TestCase(new int[] { 2, 2, 2, 2, 3, 3, 2 }, 10)]
        [TestCase(new int[] { 2, 4, 2, 20, 9, 10, 2, 7 }, 40)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 0, 2, 0 }, 2)]
        [TestCase(new int[] { 1, 1, 1, 3, 3, 5, 5, 5, 5, 7 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(null, 0)]
        public void SumEvens(int[] numbers, int expected)
        {
            var actual = _set02.SumEvens(numbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, true)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, true)]
        [TestCase(new int[] { 1, 2, 2, 3, 4 }, false)]
        [TestCase(new int[] { 1, -2, -2, 3, -4 }, false)]
        [TestCase(new int[] { 1, -2, 2, 3, 4 }, false)]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, true)]
        [TestCase(new int[] { 1, 3, 5, 8 }, true)]
        [TestCase(new int[] { 10, 10, 10, 10 }, false)]
        [TestCase(new int[] { 0, 1, 0 }, true)]
        [TestCase(new int[] { }, false)]
        [TestCase(null, false)]
        public void IsSumOdd(int[] numbers, bool expected)
        {
            // Arrange
            var numbersList = numbers == null ? null : new List<int>(numbers);

            // Act
            var actual = _set02.IsSumOdd(numbersList);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 2)]
        [TestCase(6, 3)]
        [TestCase(7, 3)]
        [TestCase(1999999999, 999999999)]
        [TestCase(2000000000, 1000000000)]
        [TestCase(-1, 0)]
        [TestCase(-4, 0)]
        [TestCase(-1000, 0)]
        public void CountOfPositiveOddsBelowNumber(int number, int expected)
        {
            var actual = _set02.CountOfPositiveOddsBelowNumber(number);
            Assert.AreEqual(expected, actual);
        }


    }
}
