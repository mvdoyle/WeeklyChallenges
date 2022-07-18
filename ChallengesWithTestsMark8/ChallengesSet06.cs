using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            /*List<string> myList = new List<string>();

          
                if(myList.Contains(""))
                {
                    return true;
                }

                else
                {
                    return false; 
                }*/

            bool containsWord = false;

            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
           
            if(ignoreCase == true) // can also do if(ignoreCase) for true and if(!ignoreCase) is not true
            {
                word = word.ToLower();

                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }

            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num) //only divisible by themsevles or 1
        {
            /*for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }

            return true;*/

            var isPrime = false;

            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0) //if divisible by 2 it's an even number, not a prime number. If it's not divisible by 2 and not divisible by 3
                {
                    isPrime = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                isPrime = true;
            }

            if(num == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }
           
   
        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1; //if there is no unqiue index returns -1

            bool uindex;

            for(int i = 0; i < str.Length; i ++)
            {
                uindex = true;

                for(int j = 0; j < str.Length; j++)
                {
                    if(str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if(uindex == true)
                {
                    index = i;
                }

            }

            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            /* for( int i = 0; i < numbers.Length; i++)
             {

             }*/

            int count = 0;

            for(var i = 0; i <numbers.Length; i++)
            {
                int currentCount = 1;

                for(var j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if(currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            /*  for(int i = 0; i < elements.Count; i+=n)
              {
                  yield return elements[i];
              }*/

            List<double> nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count )
            {
                return nthElement.ToArray();
            }

            for(var i = n - 1; i < elements.Count; i+= n ) //minus 1 b/c using 0 based indexing
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
        }
    }
}
