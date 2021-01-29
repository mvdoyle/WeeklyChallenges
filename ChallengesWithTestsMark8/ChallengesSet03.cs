using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);

            //bool isfalse = false;

            //foreach (var val in vals)
            //{
            //    if (val == false)
            //        isfalse = true;
            //}
            //return isfalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;

            //int x = 0;
            //bool isOdd;
            //if (numbers == null)
            //    return false;
            //else
            //{
            //    foreach (var num in numbers)
            //    {
            //        x += num;
            //    }
            //}

            //isOdd = x % 2 == 0 ? false : true;
            //return isOdd;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            return password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);

            //if (password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x)) && password.Any(x => char.IsDigit(x)))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //bool hasUpLowNum = true;
            //var hasUp = password.Any(Char.IsUpper);
            //var hasLow = password.Any(Char.IsLower);
            //var hasNum = password.Any(Char.IsDigit);
            //hasUpLowNum = (hasUpLowNum == hasUp && hasUpLowNum == hasLow && hasUpLowNum == hasNum);
            //return hasUpLowNum;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;

            //if (divisor == 0)
            //    return 0;
            //else
            //    return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
            //return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            };

            return odds;

            //int oddIncrement = 1;
            //int[] x = new int[50];
            //for (int i = 0; i < 50; i++)
            //{
            //    x[i] = oddIncrement;
            //    oddIncrement += 2;
            //}
            //return x;

            //int count = 0;
            //int i = 1;
            //while (count < 50)
            //{
            //    x[count] = i;
            //    count++;
            //    i += 2;
            //}
            //return x;
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
