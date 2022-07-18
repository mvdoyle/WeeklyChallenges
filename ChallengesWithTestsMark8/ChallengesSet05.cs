using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            

            foreach(var business in businesses)
            {
                if(business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }

                
            }
            //another way to do it

            //for (var i = 0; i < businesses.Length; i++)

            // if(businesses[i].TotalRevenue == 0)
            // {

            // businesses[i].Name = "CLOSED";

            // }
        }

        public bool IsAscendingOrder(int[] numbers) 
        {

            if( numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for(var i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;


           

        //started at index 1 to check the previous index. start at one and compare to 0

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
           if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for(int i = 1; i < numbers.Length; i ++)
            {
                if(numbers[i - 1]  % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach(var word in words)
            {
                if(word.Trim().Length > 0 )
                {
                    sentence += word.Trim() + " ";
                }
            }

            if(sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
           if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> fourthElement = new List<double>();
            for(var i = 3; i < elements.Count; i += 4)
            {
                fourthElement.Add(elements[i]);
            }

            return fourthElement.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
