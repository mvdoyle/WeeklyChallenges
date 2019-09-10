using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet05Tests
    {
        [Theory]
        [InlineData(5, 9, 9)]
        [InlineData(5, 2, 6)]
        [InlineData(21, 20, 40)]
        [InlineData(102, 5, 105)]
        [InlineData(0, 7, 7)]
        [InlineData(100, 5, 105)]
        [InlineData(3, 6, 6)]
        public void NextNumberDivisibleByN(int startNumber, int n, int expected)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();

            // Act
            int actual = challenger.GetNextNumberDivisibleByN(startNumber, n);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 100d, 10d, 0d, 250d })]
        [InlineData(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 0.5d, 0d, 0d, 1d })]
        [InlineData(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 99d, 65d, 80d, 35d })]
        [InlineData(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 0d, 1d, 2d, 3d })]
        [InlineData(new[] { "Test1", "Test2", "Test3" }, new[] { 22d, 33d, 44d })]
        [InlineData(new[] { "Test1", "Test2", "Test3" }, new[] { 55d, 11d, 0d })]
        [InlineData(new[] { "Test1" }, new[] { 100d })]
        [InlineData(new[] { "Test1" }, new[] { 0d })]
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(string[] names, double[] revenues)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();
            Business[] businesses = new Business[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                businesses[i] = new Business()
                {
                    Name = names[i],
                    TotalRevenue = revenues[i]
                };
            }

            // Act
            challenger.ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(businesses);

            // Assert
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    Assert.Equal("CLOSED", business.Name);
                }
                else
                {
                    Assert.NotEqual("CLOSED", business.Name);
                }
            }
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, true)]
        [InlineData(new[] { -3, -2, -1 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [InlineData(new[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 6, 6, 6 }, true)]
        [InlineData(new[] { 10, 1000, 1002 }, true)]
        [InlineData(new[] { -1000, -1000, -500, 0, 1000000 }, true)]
        [InlineData(new[] { 10 }, true)]
        [InlineData(new[] { 3, 2, 1 }, false)]
        [InlineData(new[] { 0, -1, -2 }, false)]
        [InlineData(new[] { 1, 2, 3, 2 }, false)]
        [InlineData(new[] { 1, 2, 4, 3, 5 }, false)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 4, 4, 3 }, false)]
        [InlineData(new[] { -1000, -500, -500, 10000000, 1000000 }, false)]
        [InlineData(new[] { 5, 2, 3, 4 }, false)]
        [InlineData(new[] { 1, 0 }, false)]
        [InlineData(new int[] { }, false)]
        [InlineData(null, false)]
        public void IsAscendingOrder(int[] nums, bool expected)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();

            // Act
            bool actual = challenger.IsAscendingOrder(nums);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 8)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, 5)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, 1)]
        [InlineData(new int[] { 1, -2, 2, 3, 4 }, 5)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 0)]
        [InlineData(new int[] { 1, 3, 5, 8 }, 0)]
        [InlineData(new int[] { 10, 10, 10, 10 }, 30)]
        [InlineData(new int[] { 0, 1, 0 }, 1)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void SumElementsThaFollowAnEven(int[] numbers, int expected)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();

            // Act
            int actual = challenger.SumElementsThatFollowAnEven(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "Hello,", "world" }, "Hello, world.")]
        [InlineData(new string[] { "This", "is", "only", "a", "test" }, "This is only a test.")]
        [InlineData(new string[] { "This", "is", "", "a", "test" }, "This is a test.")]
        [InlineData(new string[] { "This", "is", " ", "a", "test" }, "This is a test.")]
        [InlineData(new string[] { "This", "is ", "  ", "a  ", " test  " }, "This is a test.")]
        [InlineData(new string[] { " ", " " }, "")]
        [InlineData(new string[] { }, "")]
        [InlineData(null, "")]
        public void TurnWordsIntoSentence(string[] words, string expected)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();

            // Act
            string actual = challenger.TurnWordsIntoSentence(words);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new[] { 4d, 8, 12, 16 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, new[] { 4d, 8, 12 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new[] { 4d, 8, 12 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new[] { 4d, 8 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8 }, new[] { 4d, 8 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7 }, new[] { 4d })]
        [InlineData(new[] { 1d, 2, 3, 4 }, new[] { 4d })]
        [InlineData(new[] { 1d, 2, 3 }, new double[] { })]
        [InlineData(new[] { 1d }, new double[] { })]
        [InlineData(new double[] { }, new double[] { })]
        [InlineData(null, new double[] { })]
        public void GetEveryFourthElement(double[] numbers, double[] expected)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();
            List<double> numbersAsList = numbers == null ? null : new List<double>(numbers);

            // Act
            double[] actual = challenger.GetEveryFourthElement(numbersAsList);

            // Assert
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(Math.Round(expected[i], 4), Math.Round(actual[i], 4));
            }
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 5, true)]
        [InlineData(new[] { 1, 2, 3 }, 3, true)]
        [InlineData(new[] { 7, 3, 20 }, 10, true)]
        [InlineData(new[] { 7, 3, 20 }, 27, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 3, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 9, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 10, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 14, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 2, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 4, true)]
        [InlineData(new[] { 5, -2, 4, 4, 8 }, 8, true)]
        [InlineData(new[] { 5, -2, 4, 4 }, 8, true)]
        [InlineData(new[] { 3, -3 }, 0, true)]
        [InlineData(new[] { 3, -3, 3, -3 }, -6, true)]
        [InlineData(new[] { 3, -3, 3, -3 }, 0, true)]
        [InlineData(new[] { 3, -3, 3, -3 }, 6, true)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 20, false)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 5, false)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 8, false)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 15, false)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, 0, false)]
        [InlineData(new[] { 5, -2, 4, 6, 8 }, -2, false)]
        [InlineData(new[] { 4 }, 8, false)]
        [InlineData(new[] { 4 }, 4, false)]
        [InlineData(new int[] { }, 1, false)]
        [InlineData(new int[] { }, 0, false)]
        public void TwoDifferentElementsInArrayCanSumToTargetNumber(int[] numbers, int targetNumber, bool expected)
        {
            // Arrange
            ChallengesSet05 challenger = new ChallengesSet05();

            // Act
            bool actual = challenger.TwoDifferentElementsInArrayCanSumToTargetNumber(numbers, targetNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
