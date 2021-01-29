using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //return num1 == num2;
            //return num1 == num2 ? true : false;
            if (num1 == num2)
                return true;
            else
                return false;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //return minuend - subtrahend;
            double result = minuend - subtrahend;
            return result;
        }

        public int Add(int number1, int number2)
        {
            //return number1 + number2;
            int result = number1 + number2;
            return result;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //return number1 < number2 ? number1 : number2;
            if (number1 < number2)
                return number1;
            else
                return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            //return factor1 * factor2;
            if (factor1 == 0 || factor2 == 0)
                return 0;
            else
            {
                long result = factor1 * factor2;
                return result;
            }
        }

        public string GetGreeting(string nameOfPerson)
        {
            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";

            //if (nameOfPerson == null)
            //    return "Hello!";
            //else if (nameOfPerson == "")
            //    return "Hello!";
            //else
            //    return $"Hello, {nameOfPerson}!";
        }

        public string GetHey() => "HEY!";
        //{
        //    return "HEY!";
        //}
    }
}
