using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet06Tests
    {
        [Theory]
        [InlineData(new string[] { "alpha", "bravo", "charlie" }, "alpha", true, true)]
        [InlineData(new string[] { "alpha", "bravo", "charlie" }, "alpha", false, true)]
        [InlineData(new string[] { "alpha", "bravo", "charlie" }, "bravo", true, true)]
        [InlineData(new string[] { "alpha", "bravo", "charlie" }, "charlie", true, true)]
        [InlineData(new string[] { "Alpha", "bravo", "charlie" }, "alpha", true, true)]
        [InlineData(new string[] { "Alpha", "braVo", "charlie" }, "bravo", true, true)]
        [InlineData(new string[] { "Alpha", "bravo", "chArlie" }, "charlie", true, true)]
        [InlineData(new string[] { "AlPha", "alpha", "bravo", "charlie" }, "alpha", false, true)]
        [InlineData(new string[] { "AlPha", "bravo", "charlie" }, "alpha", false, false)]
        [InlineData(new string[] { "alpha", "bravo", "charlie" }, "delta", true, false)]
        [InlineData(new string[] { null, "bravo", "charlie" }, "braVo", false, false)]
        [InlineData(new string[] { null, "bravo", "chArlie" }, "charliE", false, false)]
        [InlineData(new string[] { null, null, "charlie" }, "bravo", true, false)]
        [InlineData(null, "alpha", true, false)]
        public void CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase, bool expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();

            // Act
            bool actual = challenger.CollectionContainsWord(words, word, ignoreCase);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(1523, true)]
        [InlineData(26357, true)]
        [InlineData(37117, true)]
        [InlineData(83791, true)]
        [InlineData(91199, true)]
        [InlineData(91387, true)]
        [InlineData(91909, true)]
        [InlineData(99991, true)]
        [InlineData(1, false)]
        [InlineData(4, false)]
        [InlineData(2000, false)]
        [InlineData(10011, false)]
        [InlineData(99561, false)]
        [InlineData(99987, false)]
        [InlineData(0, false)]
        [InlineData(-1, false)]
        [InlineData(-5, false)]
        [InlineData(-101, false)]
        [InlineData(-99991, false)]
        public void IsPrimeNumber(int number, bool expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();

            // Act
            bool actual = challenger.IsPrimeNumber(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aaaa", -1)]
        [InlineData("aaa", -1)]
        [InlineData("aa", -1)]
        [InlineData("a", 0)]
        [InlineData("", -1)]
        [InlineData("ab", 1)]
        [InlineData("abb", 0)]
        [InlineData("aba", 1)]
        [InlineData("aab", 2)]
        [InlineData("aabaa", 2)]
        [InlineData("aabbc", 4)]
        [InlineData("aabcc", 2)]
        [InlineData("aabbcddee", 4)]
        [InlineData("aaabbbcdddeee", 6)]
        [InlineData("aaabbbcdddeeeffg", 15)]
        [InlineData("abbbccdddeeeffgg", 0)]
        public void LastUniqueIndex(string str, int expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();

            // Act
            int actual = challenger.IndexOfLastUniqueLetter(str);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 10, 3, 1, 1, 1, 5, 1 }, 3)]
        [InlineData(new int[] { 1, 2, 2, 3, 3, 3, 3, 2, 5 }, 4)]
        [InlineData(new int[] { 1, 2, 2, 3, 3, 3, 3 }, 4)]
        [InlineData(new int[] { 1, 2, 2, 3, 2 }, 2)]
        [InlineData(new int[] { 3, 3, 3, 2, 2 }, 3)]
        [InlineData(new int[] { 1, 3, 2, 3, 3, 3, 3 }, 4)]
        public void MaxConsecutiveCount(int[] numbers, int expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();

            // Act
            int actual = challenger.MaxConsecutiveCount(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 4, new[] { 4d, 8, 12, 16 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 3, new[] { 3d, 6, 9, 12, 15 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 2, new[] { 2d, 4, 6, 8, 10, 12, 14, 16 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5 }, 1, new[] { 1d, 2, 3, 4, 5 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 8, new[] { 8d, 16 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 10, new[] { 10d })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 20, new double[] { })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, -2, new double[] { })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 4, new[] { 4d, 8, 12 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 4, new[] { 4d, 8 })]
        [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7 }, 4, new[] { 4d })]
        [InlineData(new[] { 1d }, 1, new[] { 1d })]
        [InlineData(new[] { 1d }, -1, new double[] { })]
        [InlineData(new double[] { }, 0, new double[] { })]
        [InlineData(new double[] { }, 1, new double[] { })]
        [InlineData(null, 0, new double[] { })]
        [InlineData(null, 1, new double[] { })]
        public void GetEveryNthElement_List(double[] numbers, int n, double[] expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();
            List<double> numbersAsList = numbers == null ? null : new List<double>(numbers);

            // Act
            double[] actual = challenger.GetEveryNthElement(numbersAsList, n);

            // Assert
            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(Math.Round(expected[i], 4), Math.Round(actual[i], 4));
            }
        }


        [Theory]
        [InlineData(new double[] { 100, 100, 100 }, new double[] { 95, 90, 80 }, 0)]
        [InlineData(new double[] { 100, 100, 100 }, new double[] { 95, 110, 120 }, 2)]
        [InlineData(new double[] { 100 }, new double[] { 90 }, 0)]
        [InlineData(new double[] { 100 }, new double[] { 110 }, 1)]
        [InlineData(new double[] { }, new double[] { }, 0)]
        [InlineData(null, null, 0)]
        public void CountOfBusinessesWithNegativeNetProfit(double[] revenues, double[] expenses, int expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();
            List<Business> businesses = new List<Business>();
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
            int actual = challenger.CountOfBusinessesWithNegativeNetProfit(businesses);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 100d, 100, 100 }, new[] { 110d, 90, 80 }, new[] { "Business A", "Business B", "Business C" }, "Business B,Business C")]
        [InlineData(new[] { 100d, 100, 100 }, new[] { 90d, 110, 110 }, new[] { "Business A", "Business B", "Business C" }, "Business A")]
        [InlineData(new[] { 100d, 100, 100 }, new[] { 110d, 110, 110 }, new[] { "Business A", "Business B", "Business C" }, "")]
        [InlineData(new[] { 100d, 100, 100, 100, 100, 100, 100 }, new[] { 110d, 90, 110, 90, 110, 110, 90 }, new[] { "A", "B", "C", "D", "E", "F", "G" }, "B,D,G")]
        public void GetCommaSeparatedListOfProfitableBusinesses(double[] revenues, double[] expenses, string[] names, string expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();
            List<Business> businesses = new List<Business>();
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
            string actual = challenger.GetCommaSeparatedListOfProfitableBusinesses(businesses);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A", "B", "C", "D", "E")]
        [InlineData("C", "D")]
        [InlineData("B")]
        [InlineData("A", "B", "C", "D", "E", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X")]
        [InlineData("C1", "C2", "C3", "C4", "C5", "C6", null, "C7", "C8", "C9", "C10")]
        public void GetNameOfHighestParentCompany(params string[] namesInOrder)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();
            string expected = namesInOrder[namesInOrder.Length - 1];
            Business headNode = new Business();
            Business current = headNode;
            for (int i = 0; i < namesInOrder.Length; i++)
            {
                current.Name = namesInOrder[i];
                current.ParentCompany = i == namesInOrder.Length - 1 ? null : new Business();
                current = current.ParentCompany;
            }

            // Act
            string actual = challenger.GetNameOfHighestParentCompany(headNode);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new char[] { 'X', 'X', 'X' }, // Top row
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengesSet06.TicTacToeResult.X)]

        [InlineData(new char[] { 'X', 'X', 'O' }, // Middle row
                    new char[] { 'O', 'O', 'O' },
                    new char[] { 'X', 'O', 'X' }, ChallengesSet06.TicTacToeResult.O)]

        [InlineData(new char[] { 'O', 'X', 'X' }, // Bottom row
                    new char[] { 'X', 'X', 'O' },
                    new char[] { 'O', 'O', 'O' }, ChallengesSet06.TicTacToeResult.O)]

        [InlineData(new char[] { 'O', 'O', 'X' }, // Left column
                    new char[] { 'O', 'X', 'X' },
                    new char[] { 'O', 'X', 'O' }, ChallengesSet06.TicTacToeResult.O)]

        [InlineData(new char[] { 'O', 'X', 'X' }, // Middle column
                    new char[] { 'X', 'X', 'O' },
                    new char[] { 'O', 'X', 'O' }, ChallengesSet06.TicTacToeResult.X)]

        [InlineData(new char[] { 'O', 'O', 'X' }, // Right column
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'O', 'X', 'X' }, ChallengesSet06.TicTacToeResult.X)]

        [InlineData(new char[] { 'X', 'O', 'X' }, // Forward diagonal
                    new char[] { 'O', 'X', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengesSet06.TicTacToeResult.X)]

        [InlineData(new char[] { 'O', 'X', 'X' }, // Back diagonal
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengesSet06.TicTacToeResult.O)]

        [InlineData(new char[] { 'X', 'O', 'X' },
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'X', 'O' }, ChallengesSet06.TicTacToeResult.Draw)]

        [InlineData(new char[] { 'O', 'X', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'O', 'X', 'X' }, ChallengesSet06.TicTacToeResult.Draw)]

        [InlineData(new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'O', 'X', 'X' }, ChallengesSet06.TicTacToeResult.Draw)]
        public void GetTicTacToeWinner(char[] row1, char[] row2, char[] row3, ChallengesSet06.TicTacToeResult expected)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();
            char[,] finalBoard = new char[3, 3];
            for (int col = 0; col < 3; col++) finalBoard[0, col] = row1[col];
            for (int col = 0; col < 3; col++) finalBoard[1, col] = row2[col];
            for (int col = 0; col < 3; col++) finalBoard[2, col] = row3[col];

            // Act
            ChallengesSet06.TicTacToeResult actual = challenger.GetTicTacToeWinner(finalBoard);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, 2, new[] { 1, 2, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2 })]
        [InlineData(true, 5, new[] { 1, 5, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2, 10, 9, 5 }, new[] { 5, 1 })]
        [InlineData(true, 1, new[] { 1, 5, 3 })]
        [InlineData(false, 5, new[] { 1, 5, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2, 10, 9 }, new[] { 5, 1 })]
        [InlineData(false, 2, new[] { 1, 5, 3 }, new[] { 5, 2, 5, 8, 3 }, new[] { 2, 10, 9 }, new[] { 5, 1 })]
        [InlineData(false, 3, new int[] { })]
        [InlineData(false, 4)]
        public void EachArrayInJaggedArrayContainsTargetNumber(bool expected, int targetNumber, params int[][] numbers)
        {
            // Arrange
            ChallengesSet06 challenger = new ChallengesSet06();

            // Act
            bool actual = challenger.EachArrayInJaggedArrayContainsTargetNumber(numbers, targetNumber);

            // Assert
            Assert.Equal(expected, actual);
        }



    }
}
