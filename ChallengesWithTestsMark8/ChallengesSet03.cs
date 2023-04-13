using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            return sum % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isNumber = false;
            bool isUpper = false;
            bool isLower = false;

            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLower = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
                if (char.IsDigit(letter))
                {
                    isNumber = true;
                }
            }

            return isNumber && isUpper && isLower;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
