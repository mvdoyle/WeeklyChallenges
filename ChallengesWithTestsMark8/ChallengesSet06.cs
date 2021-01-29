using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        
            public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
            {
                bool isTrue = true;

                if (words == null)
                    return false;

                if (ignoreCase == true)
                {
                    foreach (var item in words)
                    {
                        if (item == null)
                            continue;
                        if (item.ToLower() == word)
                        {
                            isTrue = true;
                            break;
                        }
                        else
                            isTrue = false;
                    }
                }

                if (ignoreCase == false)
                {
                    foreach (var item in words)
                    {
                        if (item == null)
                            continue;
                        if (item == word)
                        {
                            isTrue = true;
                            break;
                        }
                        else
                            isTrue = false;
                    }
                }
                return isTrue;
            }

            public bool IsPrimeNumber(int num)
            {
                bool isPrime = true;
                int factorCount = 1;
                double count = 1;

                if (num <= 1)
                    isPrime = false;
                while (count < num)
                {
                    if (num % count == 0)
                    {
                        factorCount++;
                    }
                    count++;
                }
                if (factorCount > 2)
                    isPrime = false;

                return isPrime;
            }

            public int IndexOfLastUniqueLetter(string str)
            {
                return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());

                //int[] arr = new int[str.Length];

                //for (int i = 0; i < str.Length; i++)
                //{
                //    for (int j = 1; j < str.Length; j++)
                //    {
                //        if (str[i] == str[j])
                //        {
                //            arr[i]++;
                //        }
                //    }
                //}
            }

            public int MaxConsecutiveCount(int[] numbers)
            {
                var list = new List<int>();
                int count = 1;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        ++count;
                    }
                    else
                    {
                        list.Add(count);
                        count = 1;
                    }
                }

                list.Add(count);

                return list.Max();
            }

            public double[] GetEveryNthElement(List<double> elements, int n)
            {
                List<double> list = new List<double>();
                int x = n;

                if (elements == null)
                    return list.ToArray();

                for (int i = 0; i < elements.Count(); i++)
                {
                    if (elements[i] == x)
                    {
                        list.Add(elements[i]);
                        x += n;
                    }
                }
                return list.ToArray();
            }

        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null || businesses.Count < 1)
            {
                return 0;
            }

            int count = 0;
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue < biz.TotalExpenses)
                {
                    count++;
                }
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            string list = "";

            for (int i = 0; i < businesses.Count; i++)
            {
                if (businesses[i].TotalRevenue > businesses[i].TotalExpenses)
                {
                    list += $"{businesses[i].Name},";
                }
            }
            return list.TrimEnd(',');
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            while (business.ParentCompany != null)
            {
                business = business.ParentCompany;
            }
            return business.Name;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            // Horizontal X's
            //----------------------------------------------------------------------------------------------------
            if (finalBoard[0, 0] == 'X' && finalBoard[0, 1] == 'X' && finalBoard[0, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[1, 0] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[1, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[2, 0] == 'X' && finalBoard[2, 1] == 'X' && finalBoard[2, 2] == 'X')
            {
                return TicTacToeResult.X;
            }

            // Vertical X's
            //----------------------------------------------------------------------------------------------------
            else if (finalBoard[0, 0] == 'X' && finalBoard[1, 0] == 'X' && finalBoard[2, 0] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 1] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[2, 1] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 2] == 'X' && finalBoard[1, 2] == 'X' && finalBoard[2, 2] == 'X')
            {
                return TicTacToeResult.X;
            }

            // Diagonal X's
            //----------------------------------------------------------------------------------------------------
            else if (finalBoard[0, 0] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[2, 2] == 'X')
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 2] == 'X' && finalBoard[1, 1] == 'X' && finalBoard[2, 0] == 'X')
            {
                return TicTacToeResult.X;
            }




            // Horizontal O's
            //----------------------------------------------------------------------------------------------------
            else if (finalBoard[0, 0] == 'O' && finalBoard[0, 1] == 'O' && finalBoard[0, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[1, 0] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[1, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[2, 0] == 'O' && finalBoard[2, 1] == 'O' && finalBoard[2, 2] == 'O')
            {
                return TicTacToeResult.O;
            }

            // Vertical O's
            //----------------------------------------------------------------------------------------------------

            else if (finalBoard[0, 0] == 'O' && finalBoard[1, 0] == 'O' && finalBoard[2, 0] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 1] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[2, 1] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 2] == 'O' && finalBoard[1, 2] == 'O' && finalBoard[2, 2] == 'O')
            {
                return TicTacToeResult.O;
            }

            // Diagonal O's
            //----------------------------------------------------------------------------------------------------

            else if (finalBoard[0, 0] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[2, 2] == 'O')
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 2] == 'O' && finalBoard[1, 1] == 'O' && finalBoard[2, 0] == 'O')
            {
                return TicTacToeResult.O;
            }
            //---------------------------------------------------------------------------------------------------
            else
            {
                return TicTacToeResult.Draw;
            }

        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Contains(targetNumber))
                {
                    count++;
                }
            }

            if (count == numbers.Length)
            {
                return true;
            }
            return false;
        }


    }
}
