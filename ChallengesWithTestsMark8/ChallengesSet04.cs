using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //var evens = 0;
            //var odds = 0;
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evens += number;
            //    }
            //    else
            //    {
            //        odds += number;
            //    }
            //}

            //return evens - odds;

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            {
                return str1.Length;
            }
            else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                return str2.Length;
            }
            else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
            {
                return str3.Length;
            }
            else
            {
                return str4.Length;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                   sideLength2 + sideLength3 > sideLength1 &&
                   sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                double parsedNumber = double.Parse(input);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;

            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullCount++;
                }
            }

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            double count = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }

            return count == 0 ? 0 : sum / count;

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int sum = 1;

            for (int i = number; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
