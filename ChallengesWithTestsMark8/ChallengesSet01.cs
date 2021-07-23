using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;

            //return num1 == num2 ? true : false;

            //if (num1 == num2)
            //    return true;
            //else
            //    return false;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;

            //int result = number1 + number2;
            //return result;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);

            //int min = Math.Min(number1, number2);
            //return min;

            //return number1 < number2 ? number1 : number2;

            //if (number1 < number2)
            //    return number1;
            //else
            //    return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;

            //var answer = factor1 * factor2;
            //return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {

            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";

            //if (string.IsNullOrEmpty(nameOfPerson))
            //    return "Hello!";
            //else
            //    return $"Hello, {nameOfPerson}!";
        }


        public string GetHey() => "Hey!".ToUpper();
        //{
        //    return "HEY!";

        //    //var x = "HEY!";
        //    //return x;
        //}
    }
}
