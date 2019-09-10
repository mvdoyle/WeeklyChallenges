using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet03Tests
    {
        [Theory]
        [InlineData(new bool[] { true, true, true, true }, false)]
        [InlineData(new bool[] { true, true, true }, false)]
        [InlineData(new bool[] { true, true }, false)]
        [InlineData(new bool[] { true }, false)]
        [InlineData(new bool[] { }, false)]
        [InlineData(new bool[] { true, true, true, false }, true)]
        [InlineData(new bool[] { true, true, false, true }, true)]
        [InlineData(new bool[] { true, false, true, true }, true)]
        [InlineData(new bool[] { false, true, true, true }, true)]
        [InlineData(new bool[] { true, false, true, false }, true)]
        [InlineData(new bool[] { false, true, false, true }, true)]
        [InlineData(new bool[] { false, true, false }, true)]
        [InlineData(new bool[] { false, false }, true)]
        [InlineData(new bool[] { false }, true)]
        //[InlineData(null, false)] // Assumption: Array will not be null
        public void ArrayContainsAFalse(bool[] values, bool expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            bool actual = challenger.ArrayContainsAFalse(values);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, true)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, false)]
        [InlineData(new int[] { 1, -2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, true)]
        [InlineData(new int[] { 1, 3, 5, 8 }, true)]
        [InlineData(new int[] { 10, 10, 10, 10 }, false)]
        [InlineData(new int[] { 0, 1, 0 }, true)]
        [InlineData(new int[] { }, false)]
        [InlineData(null, false)]
        public void IsSumOfOddsOdd(IEnumerable<int> numbers, bool expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            bool actual = challenger.IsSumOfOddsOdd(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aB1", true)]
        [InlineData("Ab2", true)]
        [InlineData("aabB3", true)]
        [InlineData("aabb4B", true)]
        [InlineData("ABC5d", true)]
        [InlineData("Test123", true)]
        [InlineData("c0rrectHorsebatterystaple", true)]
        [InlineData("correcthorseBatt3rystaple", true)]
        [InlineData("ab1", false)]
        [InlineData("Abc", false)]
        [InlineData("AB1", false)]
        [InlineData("abc", false)]
        [InlineData("ABC", false)]
        [InlineData("123", false)]
        [InlineData("test123", false)]
        [InlineData("TEST123", false)]
        [InlineData("correcthorsebatterystaple", false)]
        [InlineData("correcthorsebatteryStaple", false)]
        [InlineData("correcthorsebatterystapl3", false)]
        [InlineData("CORRECTHORSEBATTERYSTAPLE", false)]
        [InlineData("C0RRECTHORS3BATTERYSTAPLE", false)]
        public void PasswordContainsUpperLowerAndNumber(string password, bool expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            bool actual = challenger.PasswordContainsUpperLowerAndNumber(password);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("test", 't')]
        [InlineData("Test", 'T')]
        [InlineData("1test", '1')]
        [InlineData("aString", 'a')]
        [InlineData("7seas", '7')]
        [InlineData("zebra", 'z')]
        [InlineData("!cool", '!')]
        [InlineData("#C", '#')]
        [InlineData("\u2222test", '\u2222')]
        [InlineData("+100", '+')]
        [InlineData("--i", '-')]
        [InlineData("\\test", '\\')]
        public void GetFirstLetterOfString(string str, char expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            char actual = challenger.GetFirstLetterOfString(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("test", 't')]
        [InlineData("tesT", 'T')]
        [InlineData("test1", '1')]
        [InlineData("Stringa", 'a')]
        [InlineData("seas7", '7')]
        [InlineData("zebraz", 'z')]
        [InlineData("cool!", '!')]
        [InlineData("C#", '#')]
        [InlineData("test\u2222", '\u2222')]
        [InlineData("100+", '+')]
        [InlineData("i--", '-')]
        [InlineData("test\\", '\\')]
        public void GetLastLetterOfString(string str, char expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            char actual = challenger.GetLastLetterOfString(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(10, 3, 3.3333)]
        [InlineData(-10, 5, -2)]
        [InlineData(-10, 3, -3.3333)]
        [InlineData(0, 5, 0)]
        [InlineData(25, 24, 1.04166)]
        [InlineData(53, 7, 7.57142)]
        [InlineData(5, 0, 0)] // Assumption: Dividing by zero returns 0 for this method
        public void Divide(decimal dividend, decimal divisor, decimal expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            decimal actual = challenger.Divide(dividend, divisor);

            // Assert
            Assert.Equal(Math.Round(expected, 4), Math.Round(actual, 4));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 3, 2, 1 }, -2)]
        [InlineData(new int[] { 0, 5, 10 }, 10)]
        [InlineData(new int[] { 1, 2, 30 }, 29)]
        [InlineData(new int[] { 1, 2, 3, 2, 1 }, 0)]
        [InlineData(new int[] { -5, 1, 1, 1, 1, 5 }, 10)]
        [InlineData(new int[] { -5, 1, 1, 1, 1, -5 }, 0)]
        [InlineData(new int[] { 5, 1, 1, 1, 1, -5 }, -10)]
        [InlineData(new int[] { 50, 1, 1, 1, 1, 5 }, -45)]
        [InlineData(new int[] { 5, 1, 1, 1, 1, 50 }, 45)]
        public void LastMinusFirst(int[] numbers, int expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            int actual = challenger.LastMinusFirst(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldGetOddsBelow100()
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            };

            // Act
            int[] actual = challenger.GetOddsBelow100();

            // Assert
            Assert.Equal(odds, actual);
        }

        [Theory]
        [InlineData(new[] { "abc", "def", "ghi" }, new[] { "ABC", "DEF", "GHI" })]
        [InlineData(new[] { "Abc", "dEf", "gHi" }, new[] { "ABC", "DEF", "GHI" })]
        [InlineData(new[] { "ab1zz", "de!xx", "gh;yy" }, new[] { "AB1ZZ", "DE!XX", "GH;YY" })]
        [InlineData(new[] { "ab1", "de!", "", "123", "gh;", "#e@" }, new[] { "AB1", "DE!", "", "123", "GH;", "#E@" })]
        [InlineData(new[] { "ab1", "de!" }, new[] { "AB1", "DE!" })]
        [InlineData(new[] { "ab1" }, new[] { "AB1" })]
        [InlineData(new[] { "" }, new[] { "" })]
        [InlineData(new string[] { }, new string[] { })]
        //[InlineData(null, null)] // Assumption: Array will not be null
        public void ChangeAllElementsToUppercase(string[] values, string[] expected)
        {
            // Arrange
            ChallengesSet03 challenger = new ChallengesSet03();

            // Act
            challenger.ChangeAllElementsToUppercase(values);

            // Assert
            Assert.Equal(values.Length, expected.Length);
            for (int i = 0; i < values.Length; i++)
            {
                Assert.Equal(expected[i], values[i]);
            }
        }
    }
}
