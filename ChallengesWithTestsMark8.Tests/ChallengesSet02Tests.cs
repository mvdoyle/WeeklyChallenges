using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet02Tests
    {
        [Fact]
        public void CharacterIsALetter()
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            // Check all letters
            foreach (char letter in lowercaseAlphabet)
            {
                // Act
                bool lowercaseActual = challenger.CharacterIsALetter(letter);
                bool uppercaseActual = challenger.CharacterIsALetter(char.ToUpper(letter));

                // Assert
                Assert.True(lowercaseActual);
                Assert.True(uppercaseActual);
            }
        }

        [Fact]
        public void CharacterIsNotALetter()
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();
            string nonLetters = "0123456789`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?\u2222";

            // Check all letters
            foreach (char letter in nonLetters)
            {
                // Act
                bool actual = challenger.CharacterIsALetter(letter);

                // Assert
                Assert.False(actual);
            }
        }

        [Theory]
        [InlineData(new string[] { }, true)]
        [InlineData(new string[] { "a", "b" }, true)]
        [InlineData(new string[] { "a", "b", "c", "d" }, true)]
        [InlineData(new string[] { "", "", "", "", "", "" }, true)]
        [InlineData(new string[] { "a" }, false)]
        [InlineData(new string[] { "a", "b", "c" }, false)]
        [InlineData(new string[] { "a", "b", "c", "d", "e" }, false)]
        // [InlineData(null, false)] // Assumption: array will not be null
        public void CountOfElementsIsEven(string[] strings, bool expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            bool actual = challenger.CountOfElementsIsEven(strings);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(6, true)]
        [InlineData(8, true)]
        [InlineData(-2, true)]
        [InlineData(-4, true)]
        [InlineData(1, false)]
        [InlineData(3, false)]
        [InlineData(5, false)]
        [InlineData(7, false)]
        [InlineData(-1, false)]
        [InlineData(-3, false)]
        public void IsNumberEven(int number, bool expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            bool actual = challenger.IsNumberEven(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(4, false)]
        [InlineData(6, false)]
        [InlineData(8, false)]
        [InlineData(-2, false)]
        [InlineData(-4, false)]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(-1, true)]
        [InlineData(-3, true)]
        public void IsNumberOdd(int number, bool expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            bool actual = challenger.IsNumberOdd(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 0 }, 0)]
        [InlineData(new double[] { 5 }, 10)]
        [InlineData(new double[] { 0, 0 }, 0)]
        [InlineData(new double[] { -5, 0 }, -5)]
        [InlineData(new double[] { 0, 5 }, 5)]
        [InlineData(new double[] { -5, 5 }, 0)]
        [InlineData(new double[] { -15.5, 1, -5, 8 }, -7.5)]
        [InlineData(new double[] { -2.7, 0, -2.3, 12, 9 }, 9.3)]
        [InlineData(new double[] { }, 0)]
        [InlineData(null, 0)]
        public void SumOfMinAndMax(IEnumerable<double> numbers, double expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            double actual = challenger.SumOfMinAndMax(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", "world", 5)]
        [InlineData("abcde", "fghi", 4)]
        [InlineData("abc", "defg", 3)]
        [InlineData("abcd", "ef", 2)]
        [InlineData("a", "bc", 1)]
        [InlineData("a", "", 0)]
        // [InlineData(null, "", 3)] // Assumption: string will not be null
        public void GetLengthOfShortestString(string str1, string str2, int expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            int actual = challenger.GetLengthOfShortestString(str1, str2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -15)]
        [InlineData(new int[] { 1, -2, 3, -4, 5 }, 3)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void Sum(int[] numbers, int expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            int actual = challenger.Sum(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -6)]
        [InlineData(new int[] { 1, -2, 3, -4, 5 }, -6)]
        [InlineData(new int[] { 2, 2, 2, 2, 3, 3, 2 }, 10)]
        [InlineData(new int[] { 2, 4, 2, 20, 9, 10, 2, 7 }, 40)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { 0, 2, 0 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 5, 5, 5, 5, 7 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void SumEvens(int[] numbers, int expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            int actual = challenger.SumEvens(numbers);

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
        public void IsSumOdd(int[] numbers, bool expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();
            List<int> numbersList = numbers == null ? null : new List<int>(numbers);

            // Act
            bool actual = challenger.IsSumOdd(numbersList);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(5, 2)]
        [InlineData(6, 3)]
        [InlineData(7, 3)]
        [InlineData(1999999999, 999999999)]
        [InlineData(2000000000, 1000000000)]
        [InlineData(-1, 0)]
        [InlineData(-4, 0)]
        [InlineData(-1000, 0)]
        public void CountOfPositiveOddsBelowNumber(int number, int expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            double actual = challenger.CountOfPositiveOddsBelowNumber(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
