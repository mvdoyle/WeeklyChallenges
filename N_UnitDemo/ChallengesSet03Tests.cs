using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet03Tests
    {
        private ChallengesSet03 _set03;

        [SetUp]
        public void Setup()
        {
            _set03 = new ChallengesSet03();
        }

        [TestCase(new bool[] { true, true, true, true }, false)]
        [TestCase(new bool[] { true, true, true }, false)]
        [TestCase(new bool[] { true, true }, false)]
        [TestCase(new bool[] { true }, false)]
        [TestCase(new bool[] { }, false)]
        [TestCase(new bool[] { true, true, true, false }, true)]
        [TestCase(new bool[] { true, true, false, true }, true)]
        [TestCase(new bool[] { true, false, true, true }, true)]
        [TestCase(new bool[] { false, true, true, true }, true)]
        [TestCase(new bool[] { true, false, true, false }, true)]
        [TestCase(new bool[] { false, true, false, true }, true)]
        [TestCase(new bool[] { false, true, false }, true)]
        [TestCase(new bool[] { false, false }, true)]
        [TestCase(new bool[] { false }, true)]
        //[InlineData(null, false)] // Assumption: Array will not be null
        public void ArrayContainsAFalse(bool[] values, bool expected)
        {
            var actual = _set03.ArrayContainsAFalse(values);
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
        public void IsSumOfOddsOdd(IEnumerable<int> numbers, bool expected)
        {
            var actual = _set03.IsSumOfOddsOdd(numbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("aB1", true)]
        [TestCase("Ab2", true)]
        [TestCase("aabB3", true)]
        [TestCase("aabb4B", true)]
        [TestCase("ABC5d", true)]
        [TestCase("Test123", true)]
        [TestCase("c0rrectHorsebatterystaple", true)]
        [TestCase("correcthorseBatt3rystaple", true)]
        [TestCase("ab1", false)]
        [TestCase("Abc", false)]
        [TestCase("AB1", false)]
        [TestCase("abc", false)]
        [TestCase("ABC", false)]
        [TestCase("123", false)]
        [TestCase("test123", false)]
        [TestCase("TEST123", false)]
        [TestCase("correcthorsebatterystaple", false)]
        [TestCase("correcthorsebatteryStaple", false)]
        [TestCase("correcthorsebatterystapl3", false)]
        [TestCase("CORRECTHORSEBATTERYSTAPLE", false)]
        [TestCase("C0RRECTHORS3BATTERYSTAPLE", false)]
        public void PasswordContainsUpperLowerAndNumber(string password, bool expected)
        {
            var actual = _set03.PasswordContainsUpperLowerAndNumber(password);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("test", 't')]
        [TestCase("Test", 'T')]
        [TestCase("1test", '1')]
        [TestCase("aString", 'a')]
        [TestCase("7seas", '7')]
        [TestCase("zebra", 'z')]
        [TestCase("!cool", '!')]
        [TestCase("#C", '#')]
        [TestCase("\u2222test", '\u2222')]
        [TestCase("+100", '+')]
        [TestCase("--i", '-')]
        [TestCase("\\test", '\\')]
        public void GetFirstLetterOfString(string str, char expected)
        {
            var actual = _set03.GetFirstLetterOfString(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("test", 't')]
        [TestCase("tesT", 'T')]
        [TestCase("test1", '1')]
        [TestCase("Stringa", 'a')]
        [TestCase("seas7", '7')]
        [TestCase("zebraz", 'z')]
        [TestCase("cool!", '!')]
        [TestCase("C#", '#')]
        [TestCase("test\u2222", '\u2222')]
        [TestCase("100+", '+')]
        [TestCase("i--", '-')]
        [TestCase("test\\", '\\')]
        public void GetLastLetterOfString(string str, char expected)
        {
            var actual = _set03.GetLastLetterOfString(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(10, 3, 3.3333)]
        [TestCase(-10, 5, -2)]
        [TestCase(-10, 3, -3.3333)]
        [TestCase(0, 5, 0)]
        [TestCase(25, 24, 1.04166)]
        [TestCase(53, 7, 7.57142)]
        [TestCase(5, 0, 0)] // Assumption: Dividing by zero returns 0 for this method
        public void Divide(decimal dividend, decimal divisor, decimal expected)
        {
            var actual = _set03.Divide(dividend, divisor);
            Assert.AreEqual(Math.Round(expected, 4), Math.Round(actual, 4));
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 3, 2, 1 }, -2)]
        [TestCase(new int[] { 0, 5, 10 }, 10)]
        [TestCase(new int[] { 1, 2, 30 }, 29)]
        [TestCase(new int[] { 1, 2, 3, 2, 1 }, 0)]
        [TestCase(new int[] { -5, 1, 1, 1, 1, 5 }, 10)]
        [TestCase(new int[] { -5, 1, 1, 1, 1, -5 }, 0)]
        [TestCase(new int[] { 5, 1, 1, 1, 1, -5 }, -10)]
        [TestCase(new int[] { 50, 1, 1, 1, 1, 5 }, -45)]
        [TestCase(new int[] { 5, 1, 1, 1, 1, 50 }, 45)]
        public void LastMinusFirst(int[] numbers, int expected)
        {
            var actual = _set03.LastMinusFirst(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldGetOddsBelow100()
        {
            // Arrange 
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            };

            // Act
            var actual = _set03.GetOddsBelow100();

            // Assert
            Assert.AreEqual(odds, actual);
        }


        [TestCase(new[] { "abc", "def", "ghi" }, new[] { "ABC", "DEF", "GHI" })]
        [TestCase(new[] { "Abc", "dEf", "gHi" }, new[] { "ABC", "DEF", "GHI" })]
        [TestCase(new[] { "ab1zz", "de!xx", "gh;yy" }, new[] { "AB1ZZ", "DE!XX", "GH;YY" })]
        [TestCase(new[] { "ab1", "de!", "", "123", "gh;", "#e@" }, new[] { "AB1", "DE!", "", "123", "GH;", "#E@" })]
        [TestCase(new[] { "ab1", "de!" }, new[] { "AB1", "DE!" })]
        [TestCase(new[] { "ab1" }, new[] { "AB1" })]
        [TestCase(new[] { "" }, new[] { "" })]
        [TestCase(new string[] { }, new string[] { })]
        //[InlineData(null, null)] // Assumption: Array will not be null
        public void ChangeAllElementsToUppercase(string[] values, string[] expected)
        {
             _set03.ChangeAllElementsToUppercase(values);

            Assert.AreEqual(values.Length, expected.Length);
            for (int i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(expected[i], values[i]);
            }
        }
    }
}
