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


        [TestCase(new double[] { 100, 100, 100 }, new double[] { 95, 90, 80 }, 0)]
        [TestCase(new double[] { 100, 100, 100 }, new double[] { 95, 110, 120 }, 2)]
        [TestCase(new double[] { 100 }, new double[] { 90 }, 0)]
        [TestCase(new double[] { 100 }, new double[] { 110 }, 1)]
        [TestCase(new double[] { }, new double[] { }, 0)]
        [TestCase(null, null, 0)]
        public void CountOfBusinessesWithNegativeNetProfit(double[] revenues, double[] expenses, int expected)
        {
            // Arrange 
            var businesses = new List<Business>();
            if (revenues != null)
            {
                for (int i = 0; i < revenues.Length; i++)
                {
                    businesses.Add(new Business()
                    {
                        TotalRevenue = revenues[i],
                        TotalExpenses = expenses[i]
                    });
                }
            }
            else
            {
                businesses = null;
            }

            // Act
            var actual = _set06.CountOfBusinessesWithNegativeNetProfit(businesses);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { 100d, 100, 100 }, new[] { 110d, 90, 80 }, new[] { "Business A", "Business B", "Business C" }, "Business B,Business C")]
        [TestCase(new[] { 100d, 100, 100 }, new[] { 90d, 110, 110 }, new[] { "Business A", "Business B", "Business C" }, "Business A")]
        [TestCase(new[] { 100d, 100, 100 }, new[] { 110d, 110, 110 }, new[] { "Business A", "Business B", "Business C" }, "")]
        [TestCase(new[] { 100d, 100, 100, 100, 100, 100, 100 }, new[] { 110d, 90, 110, 90, 110, 110, 90 }, new[] { "A", "B", "C", "D", "E", "F", "G" }, "B,D,G")]
        public void GetCommaSeparatedListOfProfitableBusinesses(double[] revenues, double[] expenses, string[] names, string expected)
        {
            // Arrange
            var businesses = new List<Business>();
            for (int i = 0; i < revenues.Length; i++)
            {
                businesses.Add(new Business()
                {
                    TotalRevenue = revenues[i],
                    TotalExpenses = expenses[i],
                    Name = names[i]
                });
            }

            // Act
            var actual = _set06.GetCommaSeparatedListOfProfitableBusinesses(businesses);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase("A", "B", "C", "D", "E")]
        [TestCase("C", "D")]
        [TestCase("B")]
        [TestCase("A", "B", "C", "D", "E", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X")]
        [TestCase("C1", "C2", "C3", "C4", "C5", "C6", null, "C7", "C8", "C9", "C10")]
        public void GetNameOfHighestParentCompany(params string[] namesInOrder)
        {
            // Arrange
            var expected = namesInOrder[namesInOrder.Length - 1];
            var headNode = new Business();
            var current = headNode;
            for (int i = 0; i < namesInOrder.Length; i++)
            {
                current.Name = namesInOrder[i];
                current.ParentCompany = i == namesInOrder.Length - 1 ? null : new Business();
                current = current.ParentCompany;
            }

            // Act
            string actual = _set06.GetNameOfHighestParentCompany(headNode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new char[] { 'X', 'X', 'X' }, // Top row
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengesSet06.TicTacToeResult.X)]

        [TestCase(new char[] { 'X', 'X', 'O' }, // Middle row
                    new char[] { 'O', 'O', 'O' },
                    new char[] { 'X', 'O', 'X' }, ChallengesSet06.TicTacToeResult.O)]

        [TestCase(new char[] { 'O', 'X', 'X' }, // Bottom row
                    new char[] { 'X', 'X', 'O' },
                    new char[] { 'O', 'O', 'O' }, ChallengesSet06.TicTacToeResult.O)]

        [TestCase(new char[] { 'O', 'O', 'X' }, // Left column
                    new char[] { 'O', 'X', 'X' },
                    new char[] { 'O', 'X', 'O' }, ChallengesSet06.TicTacToeResult.O)]

        [TestCase(new char[] { 'O', 'X', 'X' }, // Middle column
                    new char[] { 'X', 'X', 'O' },
                    new char[] { 'O', 'X', 'O' }, ChallengesSet06.TicTacToeResult.X)]

        [TestCase(new char[] { 'O', 'O', 'X' }, // Right column
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'O', 'X', 'X' }, ChallengesSet06.TicTacToeResult.X)]

        [TestCase(new char[] { 'X', 'O', 'X' }, // Forward diagonal
                    new char[] { 'O', 'X', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengesSet06.TicTacToeResult.X)]

        [TestCase(new char[] { 'O', 'X', 'X' }, // Back diagonal
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengesSet06.TicTacToeResult.O)]

        [TestCase(new char[] { 'X', 'O', 'X' },
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'X', 'O' }, ChallengesSet06.TicTacToeResult.Draw)]

        [TestCase(new char[] { 'O', 'X', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'O', 'X', 'X' }, ChallengesSet06.TicTacToeResult.Draw)]

        [TestCase(new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'O', 'X', 'X' }, ChallengesSet06.TicTacToeResult.Draw)]
        public void GetTicTacToeWinner(char[] row1, char[] row2, char[] row3, ChallengesSet06.TicTacToeResult expected)
        {
            // Arrange
            char[,] finalBoard = new char[3, 3];
            for (int col = 0; col < 3; col++) finalBoard[0, col] = row1[col];
            for (int col = 0; col < 3; col++) finalBoard[1, col] = row2[col];
            for (int col = 0; col < 3; col++) finalBoard[2, col] = row3[col];

            // Act
            ChallengesSet06.TicTacToeResult actual = _set06.GetTicTacToeWinner(finalBoard);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(true, 2, new[] { 1, 2, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2 })]
        [TestCase(true, 5, new[] { 1, 5, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2, 10, 9, 5 }, new[] { 5, 1 })]
        [TestCase(true, 1, new[] { 1, 5, 3 })]
        [TestCase(false, 5, new[] { 1, 5, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2, 10, 9 }, new[] { 5, 1 })]
        [TestCase(false, 2, new[] { 1, 5, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2, 10, 9 }, new[] { 5, 1 })]
        [TestCase(false, 3, new int[] { })]
        [TestCase(false, 4)]
        public void EachArrayInJaggedArrayContainsTargetNumber(bool expected, int targetNumber, params int[][] numbers)
        {
            var actual = _set06.EachArrayInJaggedArrayContainsTargetNumber(numbers, targetNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
