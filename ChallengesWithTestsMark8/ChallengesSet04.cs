using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            var sum = 0;

            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }

                if(num % 2 != 0)
                {
                    sum -= num;
                }
            }

            return sum;

            //can always use linq - return numbers.Where(x => % 2 == 0).Sum() - numbers.Where(x => % 2 != 0).Sum();
        }
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };

            return list.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                 sideLength1 + sideLength2 > sideLength3 &&
                 sideLength1 + sideLength3 > sideLength2 &&
                 sideLength2 + sideLength3 > sideLength1
                 );

            //checking if all 3 of these conditions are true & all have to be true to form a triangle 
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);

            return isNumber;

            //return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Length / 2) + 1;

            var count = 0;

            foreach(var item in objs)
            {
                if(item == null)
                {
                    count++;
                }
            }

            if(count >= majority)
            {
                return true;
            }

            else
            {
                return false;
            }

            //return (count >= majority); instead of last if statement
        }

        public double AverageEvens(int[] numbers)
        {

            double sum = 0;
            double count = 0;


            if (numbers == null)
            {
                return 0;
            }

            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if(count > 0)
            {
                return sum / count;
            }

            else
            {
                return 0;
            }


            //ternary way for last if statement - return (count > 0) ? sum / count : 0;
        }

        public int Factorial(int number)
        {
            if(number == 1)
            {
                return 1;
            }

            else
            {
                return number * Factorial(number - 1);
            }

            //linq/ternary method return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((f, s) => f * s);   f = factorial s = sum
        }
    }
}
