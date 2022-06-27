using System;
using System.Collections.Generic;
using System.Linq;



namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public  bool CharacterIsALetter(char c)
        {
            

            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            return vals.Count() % 2 == 0;

           // return (vals.Length % 2 == 0) ? true : false
           //both tests work 


        }

        public bool IsNumberEven(int number)
         
        {

            //return (number % 2 == 0);

            return (number % 2 == 0) ? true : false;

               //both tests work
               
        }
     

        public bool IsNumberOdd(int num)
        {

            return (num % 2 != 0);

        
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null || numbers.Count() == 0)


            {

                return 0;

            }

            else
            {



                return numbers.Min() + numbers.Max();

            }
            //numbers.Count would give us access to Ienumerable
           
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {


            
           return (str1.Length > str2.Length) ? str2.Length : str1.Length; //ternary
           

            
        }

        public int Sum(int[] numbers)
        {

            return (numbers == null) ? 0 : numbers.Sum();  //if numbers == null return 0 if not return the sum of numbers


            

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }


            var sum = 0;

            foreach (var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }

            }

                return sum;
        
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }

            else
            {
                return false;
            }

            //if(numbers == null)
            //{
            //return false;
            //}

            //return (numbers.Sum() % 2 != 0);
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

           if(number < 0)
            {
                return 0;
            }

            return number / 2;



            
        }
    }
}
