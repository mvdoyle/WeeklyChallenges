using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //refactoring is faster
            return Char.IsLetter(c) ? true : false;
            
            //Original code ran in 12 ms
            //if(Char.IsLetter(c))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //refactoring
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            //refactoring runs faster            
            return number % 2 == 0 ? true : false;

            //Original code that worked in 22ms
                //if (number % 2 == 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //account for null or empty list
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
           //account for null
            if(numbers == null)
            {
                return 0;
            }

            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //account for null
            if (numbers == null)
            {
                return 0;
            }

            var sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //account for null
            if (numbers == null)
            {
                return false;
            }

            //refactoring
            return numbers.Sum() % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
