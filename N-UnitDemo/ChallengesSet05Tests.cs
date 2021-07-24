using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet05Tests
    {
        private ChallengesSet05 _set05;

        [SetUp]
        public void Setup()
        {
            _set05 = new ChallengesSet05();
        }

        [TestCase(5, 9, 9)]
        [TestCase(5, 2, 6)]
        [TestCase(21, 20, 40)]
        [TestCase(102, 5, 105)]
        [TestCase(0, 7, 7)]
        [TestCase(100, 5, 105)]
        [TestCase(3, 6, 6)]
        public void NextNumberDivisibleByN(int startNumber, int n, int expected)
        {
            var actual = _set05.GetNextNumberDivisibleByN(startNumber, n);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 100d, 10d, 0d, 250d })]
        [TestCase(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 0.5d, 0d, 0d, 1d })]
        [TestCase(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 99d, 65d, 80d, 35d })]
        [TestCase(new[] { "Test1", "Test2", "Test3", "Test4" }, new[] { 0d, 1d, 2d, 3d })]
        [TestCase(new[] { "Test1", "Test2", "Test3" }, new[] { 22d, 33d, 44d })]
        [TestCase(new[] { "Test1", "Test2", "Test3" }, new[] { 55d, 11d, 0d })]
        [TestCase(new[] { "Test1" }, new[] { 100d })]
        [TestCase(new[] { "Test1" }, new[] { 0d })]
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(string[] names, double[] revenues)
        {
            // Arrange 
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
            _set05.ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(businesses);

            // Assert
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    Assert.AreEqual("CLOSED", business.Name);
                }
            }
        }


        [TestCase(new[] { 1, 2, 3 }, true)]
        [TestCase(new[] { -3, -2, -1 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 6, 6, 6 }, true)]
        [TestCase(new[] { 10, 1000, 1002 }, true)]
        [TestCase(new[] { -1000, -1000, -500, 0, 1000000 }, true)]
        [TestCase(new[] { 10 }, true)]
        [TestCase(new[] { 3, 2, 1 }, false)]
        [TestCase(new[] { 0, -1, -2 }, false)]
        [TestCase(new[] { 1, 2, 3, 2 }, false)]
        [TestCase(new[] { 1, 2, 4, 3, 5 }, false)]
        [TestCase(new[] { 1, 1, 2, 2, 3, 4, 4, 3 }, false)]
        [TestCase(new[] { -1000, -500, -500, 10000000, 1000000 }, false)]
        [TestCase(new[] { 5, 2, 3, 4 }, false)]
        [TestCase(new[] { 1, 0 }, false)]
        [TestCase(new int[] { }, false)]
        [TestCase(null, false)]
        public void IsAscendingOrder(int[] nums, bool expected)
        {
            var actual = _set05.IsAscendingOrder(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 8)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -8)]
        [TestCase(new int[] { 1, 2, 2, 3, 4 }, 5)]
        [TestCase(new int[] { 1, -2, -2, 3, -4 }, 1)]
        [TestCase(new int[] { 1, -2, 2, 3, 4 }, 5)]
        [TestCase(new int[] { 1, 3, 5, 7 }, 0)]
        [TestCase(new int[] { 1, 3, 5, 8 }, 0)]
        [TestCase(new int[] { 10, 10, 10, 10 }, 30)]
        [TestCase(new int[] { 0, 1, 0 }, 1)]
        [TestCase(new int[] { }, 0)]
        [TestCase(null, 0)]
        public void SumElementsThaFollowAnEven(int[] numbers, int expected)
        {
            var actual = _set05.SumElementsThatFollowAnEven(numbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new string[] { "Hello,", "world" }, "Hello, world.")]
        [TestCase(new string[] { "This", "is", "only", "a", "test" }, "This is only a test.")]
        [TestCase(new string[] { "This", "is", "", "a", "test" }, "This is a test.")]
        [TestCase(new string[] { "This", "is", " ", "a", "test" }, "This is a test.")]
        [TestCase(new string[] { "This", "is ", "  ", "a  ", " test  " }, "This is a test.")]
        [TestCase(new string[] { " ", " " }, "")]
        [TestCase(new string[] { }, "")]
        [TestCase(null, "")]
        public void TurnWordsIntoSentence(string[] words, string expected)
        {
            var actual = _set05.TurnWordsIntoSentence(words);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new[] { 4d, 8, 12, 16 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, new[] { 4d, 8, 12 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new[] { 4d, 8, 12 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new[] { 4d, 8 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7, 8 }, new[] { 4d, 8 })]
        [TestCase(new[] { 1d, 2, 3, 4, 5, 6, 7 }, new[] { 4d })]
        [TestCase(new[] { 1d, 2, 3, 4 }, new[] { 4d })]
        [TestCase(new[] { 1d, 2, 3 }, new double[] { })]
        [TestCase(new[] { 1d }, new double[] { })]
        [TestCase(new double[] { }, new double[] { })]
        [TestCase(null, new double[] { })]
        public void GetEveryFourthElement(double[] numbers, double[] expected)
        {
            // Arrange
            var numbersAsList = numbers == null ? null : new List<double>(numbers);

            // Act
            var actual = _set05.GetEveryFourthElement(numbersAsList);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(Math.Round(expected[i], 4), Math.Round(actual[i], 4));
            }
        }


        [TestCase(new[] { 1, 2, 3 }, 5, true)]
        [TestCase(new[] { 1, 2, 3 }, 3, true)]
        [TestCase(new[] { 7, 3, 20 }, 10, true)]
        [TestCase(new[] { 7, 3, 20 }, 27, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 3, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 9, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 10, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 14, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 2, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 4, true)]
        [TestCase(new[] { 5, -2, 4, 4, 8 }, 8, true)]
        [TestCase(new[] { 5, -2, 4, 4 }, 8, true)]
        [TestCase(new[] { 3, -3 }, 0, true)]
        [TestCase(new[] { 3, -3, 3, -3 }, -6, true)]
        [TestCase(new[] { 3, -3, 3, -3 }, 0, true)]
        [TestCase(new[] { 3, -3, 3, -3 }, 6, true)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 20, false)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 5, false)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 8, false)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 15, false)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 0, false)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, -2, false)]
        [TestCase(new[] { 4 }, 8, false)]
        [TestCase(new[] { 4 }, 4, false)]
        [TestCase(new int[] { }, 1, false)]
        [TestCase(new int[] { }, 0, false)]
        public void TwoDifferentElementsInArrayCanSumToTargetNumber(int[] numbers, int targetNumber, bool expected)
        {
            var actual = _set05.TwoDifferentElementsInArrayCanSumToTargetNumber(numbers, targetNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
