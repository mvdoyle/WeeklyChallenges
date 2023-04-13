using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c)
                {
                    return true;
                }
            }
            return false;

            //return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //if (vals.Length % 2 == 0)
            //{
            //    return true;
            //}
            //return false;


            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            //if (number % 2 == 0)
            //{
            //    return true;
            //}
            //return false;
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }

            //return str1.Length < str2.Length ? str1.Length : str2.Length;

            //var list = new List<int>() { str1.Length, str2.Length };
            //return list.Min();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;

            //return numbers == null || numbers.Length == 0 ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;

            //return numbers == null || numbers.Length == 0 ? 0 : numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum % 2 != 0;

            //return numbers != null && numbers.Count != 0 && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }

            //return number <= 0 ? 0 : number / 2;
        }
    }
}
